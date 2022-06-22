using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAdote
{
    public class Lar
    {
        public string rua;
        public int numero;
        public string complemento;
        public string cidade;
        public string estado;
        public long cep;


        public Lar()
        {
        }

        public Lar(int codigoPostal)
        {
            this.cep = codigoPostal;
        }

        public virtual void DadosLar()
        {
            
            Console.WriteLine(" ~Rua: " + this.rua);
            Console.WriteLine(" ~Número: " + this.numero);
            Console.WriteLine(" ~Complemento: " + this.complemento);
            Console.WriteLine(" ~Cidade: " + this.cidade);
            Console.WriteLine(" ~Estado: " + this.estado);
            Console.WriteLine(" ~CEP: " + this.cep);
        }
    }
}
