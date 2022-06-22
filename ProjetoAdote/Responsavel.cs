using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAdote
{
    public class Responsavel
    {
        public string nome;
        public int idade;
        public string telefoneContato;
        public string emailContato;
        public long rg;
        public long cpf;

        public virtual void DadosResponsavel()
        {

            Console.WriteLine(" ~Nome: " + this.nome);
            Console.WriteLine(" ~Idade: " + this.idade);
            Console.WriteLine(" ~Telefone: " + this.telefoneContato);
            Console.WriteLine(" ~E-mail: " + this.emailContato);
            Console.WriteLine(" ~RG: " + this.rg);
            Console.WriteLine(" ~CPF: " + this.cpf);
        }
    }
}   
