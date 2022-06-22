using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAdote
{
    public class Gato : Animal
    {
        public string? raca;
        public string? pelagem;
        public bool aceitaOutroAnimal;

        public Gato()
        {
        }
        public Gato(int id, string nome) : base(id, nome){}       
    
        public override void ImprimirDados()
        {

            Console.WriteLine("\n.--------- PROJETO ADOTE © ----------.");
            Console.WriteLine("|    INFORMAÇÕES GERAIS DO ANIMAL    |");
            Console.WriteLine("|                GATO                |");
            Console.WriteLine("'------------------------------------'");
            base.ImprimirDados();
            Console.WriteLine(" ~Raça: " + this.raca);
            Console.WriteLine(" ~Pelagem: " + this.pelagem);
            Console.WriteLine(this.aceitaOutroAnimal == true ? " ~Aceita Outro Animal: Sim" : " ~Aceita Outro Animal: Não");

        }
    }
}
