using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIO_csharp_sistema_estacionamento.code.dal;

namespace DIO_csharp_sistema_estacionamento.code.bll
{
    internal class UsuariosBll
    {
       UsuariosDal dal = new ();

        public DataTable CarregaGridUsuario()
        {
            try
            {
                return dal.CarregaGridUsuario();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao executar a consulta (File: EstacionamentoDal.cs Função: quantidadeVagas())" + ex.Message);
            }
        }
    }
}
