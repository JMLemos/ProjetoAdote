using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAdote
{
    public class Animal
    {

        public int id;
        public string? nome;
        public int idade;
        public string? sexo;
        public string? cor;
        public bool adotado;
        public bool vacinado;
        public bool doente;
        public Lar localizacao;
        public Responsavel responsavel;

        public Animal()
        {
        }

        public Animal (int id, string nome)
        {
            this.id = id;
            this.nome = nome; 
        }


        public bool RealizarAdocao(string situacaoAdocao)
        {
            if (situacaoAdocao == "SIM")
                this.adotado = true;
            else if (situacaoAdocao == "NÃO")
                this.adotado = false;
            return this.adotado;

        }

        public bool EstaDoente(string situacaoDoenca)
        {
            if (situacaoDoenca == "SIM")
                this.doente = true;
            else if (situacaoDoenca == "NÃO")
                this.doente = false;
            return this.adotado;

        }

        public virtual void ImprimirDados()
        {
            
            
            Console.WriteLine(" ~id: " + this.id);
            Console.WriteLine(" ~Nome: " + this.nome);
            Console.WriteLine(" ~Idade: " + this.idade);
            Console.WriteLine(" ~Sexo: " + this.sexo);
            Console.WriteLine(" ~Cor: " + this.cor);
            Console.WriteLine(this.adotado == true ? " ~Adotado: Sim" : " ~Adotado: Disponível para adoção");
            Console.WriteLine(this.vacinado == true ? " ~Vacinado: Sim" : " ~Vacinado: Não");
            Console.WriteLine(this.doente == true ? " ~Doente: Sim" : " ~Doente: Não");

        }

    }
}
