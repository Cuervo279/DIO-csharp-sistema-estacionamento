using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO_csharp_sistema_estacionamento.code.dal
{
    internal class UsuariosDal
    {
        StringBuilder sql = new StringBuilder();

        public DataTable CarregaGridUsuario()
        {

            DataTable dt = new();

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(Dal.StringConexao()))
                {

                    conn.Open();

                    sql.Clear();

                    sql.Append(" SELECT                       ");
                    sql.Append("        usuario_codigo,       ");
                    sql.Append("        usuario_nome,         ");
                    sql.Append("        usuario_email,        ");
                    sql.Append("        usuario_telefone,     ");
                    sql.Append("        usuario_cpf,          ");
                    sql.Append("        usuario_tipo,         ");
                    sql.Append("        substr(usuario_datacadastro, 1, 2) || '/' || ");
                    sql.Append("        substr(usuario_datacadastro, 4, 2) || '/' || ");
                    sql.Append("        substr(usuario_datacadastro, 7, 4) AS DATAVENCTO, ");
                    sql.Append("        usuario_status,       ");
                    sql.Append("        usuario_ativo         ");
                    sql.Append(" FROM   tbl_usuarios          ");
                    

                    using (SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), conn))
                    {

                        SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);

                        da.Fill(dt);

                        return dt;
                    }

                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
