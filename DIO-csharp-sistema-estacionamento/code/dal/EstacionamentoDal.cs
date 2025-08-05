using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace DIO_csharp_sistema_estacionamento.code.dal
{
    internal class EstacionamentoDal
    {
        StringBuilder sql = new StringBuilder();

        public int quantidadeVagasLivres()
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(Dal.StringConexao()))
                {

                    conn.Open();

                    sql.Clear();

                    sql.Append(" SELECT COUNT(VAGAUTO_STATUS) FROM TBL_VAGAS ");
                    sql.Append(" WHERE VAGAUTO_STATUS = 'LIVRE' ;            ");


                    using (SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), conn))
                    {
                        object resultado = cmd.ExecuteScalar();

                        int vagasLivres = resultado != null ? Convert.ToInt32(resultado) : 0;

                        return vagasLivres;
                    }
                }
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public int quantidadeVagasOcupadas()
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(Dal.StringConexao()))
                {

                    conn.Open();

                    sql.Clear();

                    sql.Append(" SELECT COUNT(VAGAUTO_STATUS) FROM TBL_VAGAS ");
                    sql.Append(" WHERE VAGAUTO_STATUS = 'OCUPADA' ;          ");


                    using (SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), conn))
                    {
                        object resultado = cmd.ExecuteScalar();

                        int vagasLivres = resultado != null ? Convert.ToInt32(resultado) : 0;

                        return vagasLivres;
                    }
                }
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string statusVaga(int numeroVaga, string tipo)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(Dal.StringConexao()))
                {

                    conn.Open();

                    sql.Clear();

                    sql.Append(" SELECT VAGAUTO_STATUS FROM TBL_VAGAS ");
                    sql.Append(" WHERE VAGAUTO_CODIGO = @NUMEROVAGA;  ");
                    sql.Append(" AND VAGAUTO_CODIGO = @TIPOVAGA;  ");

                    using (SQLiteCommand cmd = new SQLiteCommand(sql.ToString(), conn))
                    {
                        cmd.Parameters.AddWithValue("@NUMEROVAGA", $"{numeroVaga}");
                        cmd.Parameters.AddWithValue("@TIPOVAGA", $"{tipo}");

                        object resultado = cmd.ExecuteScalar();
                        return resultado?.ToString() ?? "DESCONHECIDO";
                    }
                }
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}