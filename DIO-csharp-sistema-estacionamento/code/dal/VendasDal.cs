using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO_csharp_sistema_estacionamento.code.dal
{
    internal class VendasDal
    {
        StringBuilder sql = new StringBuilder();

        public DataTable preencheUsuarioCaixa(string cpf) 
        {

            DataTable dt = new DataTable();

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(Dal.StringConexao()))
                {

                    conn.Open();

                    sql.Clear();

                    sql.Append(" SELECT                        ");
                    sql.Append("            a.vendas_cupom,    ");
                    sql.Append("            a.vendas_entrada,  ");
                    sql.Append("            b.usuario_codigo,  "); 
                    sql.Append("            b.usuario_nome,    ");
                    sql.Append("            b.usuario_status,  ");
                    sql.Append("            b.usuario_telefone ");
                    sql.Append(" FROM       tbl_vendas a       ");
                    sql.Append(" JOIN       tbl_usuarios b ON a.usuario_codigo = b.usuario_codigo ");
                    sql.Append(" WHERE      b.usuario_cpf = @CPF;                                 ");


                    using (SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), conn))
                    {
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = sql.ToString();

                        cmd.Parameters.AddWithValue("@CPF", cpf);

                        SQLiteDataAdapter da = new SQLiteDataAdapter(cmd);

                        da.Fill(dt);
                    }
                }
            }


            catch (Exception)
            {

                throw;
            }

            return dt;
        }
    }
}
