using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIO_csharp_sistema_estacionamento.code.dal;

namespace DIO_csharp_sistema_estacionamento.code.bll
{
    internal class VendasBll
    {
        VendasDal dal = new();

        public DataTable preencheUsuarioCaixa(string cpf)
        {
            try
            {
                return dal.preencheUsuarioCaixa(cpf);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao executar a consulta (File: EstacionamentoDal.cs Função: quantidadeVagas())" + ex.Message);
            }
        }
    }
}
