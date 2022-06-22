using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAdote
{
    public class GerenteONG : Responsavel
    {
        public long cepUnidadeONG; //Aqui atribuímos o objeto LarTemporario correspondente.

        public override void DadosResponsavel()
        {
            Console.WriteLine(".------------------------------------.");
            Console.WriteLine("|         DADOS DO RESPONSÁVEL       |");
            Console.WriteLine("'------------------------------------'");
            Console.WriteLine("|                GERENTE             |");
            Console.WriteLine("'------------------------------------'");
            base.DadosResponsavel();

        }
    }
}
