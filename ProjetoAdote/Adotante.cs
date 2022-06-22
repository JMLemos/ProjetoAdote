using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAdote
{
    public class Adotante : Responsavel
    {
        public long cepLarPermanente; //Aqui atribuímos o objeto LarPermanente correspondente.
        public bool rgOK;
        public bool cpfOK;
        public bool comprovanteResidenciaOK;
        public bool termoDeResponsabilidadeOK; //Essa sequência de booleanos é para registrar a situação dos documentos.
        public bool aptoParaAdotar;


        public override void DadosResponsavel()
        {
            base.DadosResponsavel();
            Console.WriteLine("Endereço: " + this.cepLarPermanente);
            this.analiseAptidao();

        }

        public bool analiseDocumentos()
        {
            if (Convert.ToString(rg).Length == 9)
            {
                foreach (char n in Convert.ToString(rg))
                {
                    if (Char.IsNumber(n))
                    {
                        rgOK = true;
                    }
                    else
                    {
                        rgOK = false;
                        break;
                    }
                }
            }

            else
            {
                rgOK = false;
            }

            if (Convert.ToString(cpf).Length == 11)
            {
                foreach (char n in Convert.ToString(cpf))
                {
                    if (!Char.IsNumber(n))
                    {
                        cpfOK = true;
                    }
                    else
                    {
                        cpfOK = false;
                        break;
                    }

                }
            }
            else
            {
                cpfOK = false;
            }

            if (rgOK && cpfOK && comprovanteResidenciaOK && termoDeResponsabilidadeOK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void analiseAptidao()
        {
            if (this.idade >= 21 && analiseDocumentos() == true)
            {
                this.aptoParaAdotar = true;
                Console.WriteLine($"\n{this.nome} está apto para adotar.");
            }
            else if (this.idade < 21)
            {
                Console.WriteLine($"\n{this.nome} não está apto para adotar, pois tem menos de 21 anos.");
                this.aptoParaAdotar = false;
            }
            else if (analiseDocumentos() == false)
            {
                Console.WriteLine($"\n{this.nome} ainda não está apto para adotar, pois há algo irregular na documentação enviada. Favor verificar.");
                this.aptoParaAdotar = false;
            }
        }
    }
}
