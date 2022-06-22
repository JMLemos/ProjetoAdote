using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAdote
{
    class LarPermanente : Lar
    {
        public Adotante adotante;

        public LarPermanente() : base()
        {

        }

        public LarPermanente(int codigoPostal) : base(codigoPostal)
        {
            this.cep = codigoPostal;
        }

        public LarPermanente(Adotante adotante)
        {

        }

        public override void DadosLar()
        {
            Console.WriteLine(".------------------------------------.");
            Console.WriteLine("|            DADOS DO LAR            |");
            Console.WriteLine("'------------------------------------'");
            Console.WriteLine("|           LAR PERMANENTE           |");
            Console.WriteLine("'------------------------------------'");
            base.DadosLar();
            Console.WriteLine(" ~Adotante: " + this.adotante);
        }
    }
}
