using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO_csharp_sistema_estacionamento.code.dal
{
    internal class Dal
    {
        public static string StringConexao()
        {
            //string basePath = AppDomain.CurrentDomain.BaseDirectory;
            //string dbPath = Path.Combine(basePath, "DATABASE", "DBPRODUTOS.db");
            //Console.WriteLine($"Database Path: {dbPath}");
            //return $"DATA SOURCE={dbPath}";


            //return "DATA SOURCE=C:\\Leonardo Silva\\Projetos\\Confiança\\PrjCadastroProdutos-Estagio\\Cprod\\Cprod\\DATABASE\\DBPRODUTOS.db";

            return "DATA SOURCE=C:\\Programas\\Projetos\\Vanilla\\DIO-csharp-sistema-estacionamento\\DIO-csharp-sistema-estacionamento\\database.db";
        }
    }
}
