using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIO_csharp_sistema_estacionamento.code.dal;

namespace DIO_csharp_sistema_estacionamento.code.bll
{
    internal class EstacionamentoBll
    {
        EstacionamentoDal dal = new();

        public int quantidadeVagasLivres()
        {
            try
            {
                return dal.quantidadeVagasLivres();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao executar a consulta (File: EstacionamentoDal.cs Função: quantidadeVagas())" + ex.Message);
            }
        }

        public int quantidadeVagasOcupadas()
        {
            try
            {
                return dal.quantidadeVagasOcupadas();
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao executar a consulta (File: EstacionamentoDal.cs Função: quantidadeVagas())" + ex.Message);
            }
        }

        public string statusVaga(int numeroVaga, string tipoVaga)
        {
            try
            {
                return dal.statusVaga(numeroVaga, tipoVaga);
            }
            catch (Exception ex)
            {

                throw new Exception("Erro ao executar a consulta (File: EstacionamentoDal.cs Função: quantidadeVagas())" + ex.Message);
            }
        }

    }
}
