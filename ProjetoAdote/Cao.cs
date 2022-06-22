using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAdote
{
    public class Cao : Animal
    {
        public string? raca;
        public string? porte;
        public bool aceitaOutroAnimal;

        public Cao()
        {
        }
        public Cao (int id , string nome) : base (id, nome) { }

        public override void ImprimirDados()
        {
            Console.WriteLine("\n.--------- PROJETO ADOTE © ----------.");
            Console.WriteLine("|    INFORMAÇÕES GERAIS DO ANIMAL    |");
            Console.WriteLine("|                 CÃO                |");
            Console.WriteLine("'------------------------------------'");
            base.ImprimirDados();
            Console.WriteLine(" ~Raça: " + this.raca);
            Console.WriteLine(" ~Porte: " + this.porte);
            Console.WriteLine(this.aceitaOutroAnimal == true ? " ~Aceita Outro Animal: Sim" : " ~Aceita Outro Animal: Não");

        }

    }  
}
