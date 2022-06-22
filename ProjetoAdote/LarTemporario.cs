using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAdote
{
    class LarTemporario : Lar
    {
        public string nomeDoLar;
        public GerenteONG funcionario;

        public LarTemporario() : base()
        {

        }

        public LarTemporario(int codigoPostal) : base(codigoPostal)
        {
            this.cep = codigoPostal;
        }

        public LarTemporario(GerenteONG funcionario)
        {
            this.funcionario = funcionario;
        }

        public override void DadosLar()
        {
            Console.WriteLine(".------------------------------------.");
            Console.WriteLine("|             DADOS DO LAR           |");
            Console.WriteLine("'------------------------------------'");
            Console.WriteLine("|            LAR TEMPORÁRIO          |");
            Console.WriteLine("'------------------------------------'");
            Console.WriteLine(" ~Nome do lar: " + this.nomeDoLar);
            base.DadosLar();
        }   
    }
}
