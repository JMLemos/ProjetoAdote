using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAdote
{
    public class Roedor : Animal
    {
        public string? tipo;
        public bool precisaDeCompanhia;
        public Roedor()
        {
        }
        public Roedor(int id, string nome) : base (id, nome){ }

        public override void ImprimirDados()
        {
            Console.WriteLine("\n.--------- PROJETO ADOTE © ----------.");
            Console.WriteLine(  "|    INFORMAÇÕES GERAIS DO ANIMAL    |");
            Console.WriteLine(  "|              ROEDOR                |");
            Console.WriteLine(  "'------------------------------------'");
            base.ImprimirDados();
            Console.WriteLine(  " ~Tipo: " + this.tipo);
            Console.WriteLine(this.precisaDeCompanhia == true ? " ~Precisa de Companhia: Sim" : " ~Precisa de Companhia: Não");
        }

    }
}
