using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAdote
{
     class Portifolio
    {
        public static void Main()
        {
            List<Animal> animalList = new List<Animal>();
            List<Lar> larList = new List<Lar>();
            List<Responsavel> responsavelList = new List<Responsavel>();
            animalList.Add(GeracaoDeAnimaisCao1());
            animalList.Add(GeracaoDeAnimaisCao2());
            animalList.Add(GeracaoDeAnimaisCao3());
            animalList.Add(GeracaoDeAnimaisCao4());
            animalList.Add(GeracaoDeAnimaisRoedor());
            animalList.Add(GeracaoDeAnimaisGato1());
            animalList.Add(GeracaoDeAnimaisGato2());

            larList.Add(GeracaoDeLarTemporario());
            larList.Add(GeracaoDeLarTemporario2());

            responsavelList.Add(GeracaoDeResponsavel1());
            responsavelList.Add(GeracaoDeResponsavel2());
            int selecao = 0;
            do
            {
                Menu();
                selecao = int.Parse(Console.ReadLine());

                Console.Clear();

                switch (selecao)
                {
                    case 1:
                        MenuCadastroAnimal();
                        int selecaoAnimal = int.Parse(Console.ReadLine());
                        string animal = "";
                        Console.Clear();
                        if (selecaoAnimal == 1)
                        {
                            animal = "cachorro";
                            animalList.Add(MenuCadastroNovoAnimal(animal));
                            Task.Delay(3000).Wait();
                            Console.Clear();
                            Console.WriteLine($"Digite o CEP de onde o {animal} está: (Apenas os números)");
                            long cep = long.Parse(Console.ReadLine());
                            bool local = ProcurarLar(cep);
                            if (local == false)
                            {
                                Console.Clear();
                                Console.WriteLine("Local não registrado no sistema, por favor, registre-o.");

                            }
                            int index = ProcurarLarIndex(larList[larList.Count - 1].cep);
                            animalList[animalList.Count - 1].localizacao = larList[index];
                            Console.WriteLine("Local adicionado com sucesso no registro de " + animalList[animalList.Count - 1].nome + ".\n");
                            Task.Delay(3000).Wait();
                            Console.Clear();                         
                            Console.Write($"Qual o cpf do responsável por esse {animal}? ");
                            long cpf1 = long.Parse(Console.ReadLine());

                            int index5 = ProcurarFuncionarioIndex(cpf1);
                            if (index5 == -1)
                            {
                                Console.WriteLine("Pessoa não registrada no sistema.");
                            }
                            else
                            {
                                animalList[animalList.Count - 1].responsavel = responsavelList[index5];
                                Console.WriteLine("Responsável adicionado com sucesso no registro de " + animalList[animalList.Count - 1].nome + ".\n");
                            }
                            Task.Delay(3000).Wait();
                            Console.Clear();
                        }
                        else if (selecaoAnimal == 2)
                        {
                            animal = "gato";
                            animalList.Add(MenuCadastroNovoAnimal(animal));
                            Task.Delay(3000).Wait();
                            Console.Clear();
                            Console.WriteLine($"Digite o CEP de onde o {animal} está: (Apenas os números)");
                            long cep = long.Parse(Console.ReadLine());
                            bool local = ProcurarLar(cep);
                            if (local == false)
                            {
                                Console.Clear();
                                Console.WriteLine("Local não registrado no sistema, por favor, registre-o.");

                            }
                            int index = ProcurarLarIndex(cep);
                            animalList[animalList.Count - 1].localizacao = larList[index];
                            Console.WriteLine("Local adicionado com sucesso no registro de " + animalList[animalList.Count - 1].nome + ".\n");
                            Task.Delay(3000).Wait();
                            Console.Clear();
                            Console.Write($"Qual o cpf do responsável por esse {animal}? ");
                            long cpf1 = long.Parse(Console.ReadLine());

                            int index5 = ProcurarFuncionarioIndex(cpf1);
                            if (index5 == -1)
                            {
                                Console.WriteLine("Pessoa não registrada no sistema.");
                            }
                            else
                            {
                                animalList[animalList.Count - 1].responsavel = responsavelList[index5];
                                Console.WriteLine("Responsável adicionado com sucesso no registro de " + animalList[animalList.Count - 1].nome + ".\n");
                            }
                            Task.Delay(3000).Wait();
                            Console.Clear();
                        }
                        else if (selecaoAnimal == 3)
                        {
                            animal = "roedor";
                            animalList.Add(MenuCadastroNovoAnimal(animal));
                            Task.Delay(3000).Wait();
                            Console.Clear();
                            Console.WriteLine($"Digite o CEP de onde o {animal} está: (Apenas os números)");
                            long cep = long.Parse(Console.ReadLine());
                            bool local = ProcurarLar(cep);
                            if (local == false)
                            {
                                Console.Clear();
                                Console.WriteLine("Local não registrado no sistema, por favor, registre-o.\n");

                            }
                            else
                            {
                                int index = ProcurarLarIndex(cep);
                                animalList[animalList.Count - 1].localizacao = larList[index];
                                Console.WriteLine("Local adicionado com sucesso no registro de " + animalList[animalList.Count - 1].nome + ".\n");
                            }
                            Task.Delay(3000).Wait();
                            Console.Clear();
                            Console.Write($"Qual o cpf do responsável por esse {animal}? ");
                            long cpf1 = long.Parse(Console.ReadLine());

                            int index5 = ProcurarFuncionarioIndex(cpf1);
                            if (index5 == -1)
                            {
                                Console.WriteLine("Pessoa não registrada no sistema.");
                            }
                            else
                            {
                                animalList[animalList.Count - 1].responsavel = responsavelList[index5];
                                Console.WriteLine("Responsável adicionado com sucesso no registro de " + animalList[animalList.Count - 1].nome + ".\n");
                            }
                            Task.Delay(3000).Wait();
                            Console.Clear();

                        }    
                        else
                        {
                            Console.WriteLine("Opção inválida.");
                        }
                        break;
                    case 2:
                        MenuAtualizacaoAnimal();
                        Console.Clear();
                        Console.WriteLine("Qual o nome do animal que você gostaria de atualizar os dados?");
                        string nomeAnimal = Console.ReadLine();
                        int procurar = ProcurarAnimalNome(nomeAnimal);
                        if (procurar == -1)
                        {
                            Console.WriteLine("Animal não encontrado no sistema.");
                        }
                        else
                        {
                            int escolha = -1;
                            do
                            {
                                MenuAtualizacaoAnimal();
                                escolha = int.Parse(Console.ReadLine());

                                switch (escolha)
                                {
                                    case 1:
                                        Console.WriteLine(".------------------------------------.");
                                        Console.WriteLine($"O animal {animalList[procurar].nome} está adotado?");
                                        Console.WriteLine("S - Sim");
                                        Console.WriteLine("N - Não");
                                        string adotado = Console.ReadLine();
                                        
                                                            
                                  
                                        if (adotado.ToUpper() == "S")
                                        {
                                            animalList[procurar].adotado = true;
                                        }
                                        else
                                        {
                                            animalList[procurar].adotado = false;
                                        }
                                        Console.WriteLine(".------------------------------------.");
                                        Console.WriteLine("|   STATUS ATUALIZADO COM SUCESSO!   |");
                                        Console.WriteLine("'------------------------------------'");
                                        Task.Delay(3000).Wait();
                                        Console.Clear();
                                        break;
                                    case 2:
                                        Console.WriteLine(".------------------------------------.");
                                        Console.WriteLine($"O animal {animalList[procurar].nome} está vacinado?");
                                        Console.WriteLine("S - Sim");
                                        Console.WriteLine("N - Não");
                                        string vacinado = Console.ReadLine();
                                        if (vacinado.ToUpper() == "S")
                                        {
                                            animalList[procurar].vacinado = true;
                                        }
                                        else
                                        {
                                            animalList[procurar].vacinado = false;
                                        }
                                        Console.WriteLine(".------------------------------------.");
                                        Console.WriteLine("|   STATUS ATUALIZADO COM SUCESSO!   |");
                                        Console.WriteLine("'------------------------------------'");
                                        Task.Delay(3000).Wait();
                                        Console.Clear();
                                        break;
                                    case 3:
                                        Console.WriteLine(".------------------------------------.");
                                        Console.WriteLine($"O animal {animalList[procurar].nome} está doente?");
                                        Console.WriteLine("S - Sim");
                                        Console.WriteLine("N - Não");
                                        string doente = Console.ReadLine();
                                        if (doente.ToUpper() == "S")
                                        {
                                            animalList[procurar].doente = true;
                                        }
                                        else
                                        {
                                            animalList[procurar].doente = false;
                                        }
                                        Console.WriteLine(".------------------------------------.");
                                        Console.WriteLine("|   STATUS ATUALIZADO COM SUCESSO!   |");
                                        Console.WriteLine("'------------------------------------'");
                                        Task.Delay(3000).Wait();
                                        Console.Clear();
                                        break;
                                    case 4:
                                        Console.WriteLine(".------------------------------------.");
                                        Console.WriteLine($"O responsável é {animalList[procurar].responsavel.nome}");
                                        Console.WriteLine("Qual o cpf do novo responsável?");
                                        long procurarCpf = long.Parse(Console.ReadLine());
                                        int cpfExiste = ProcurarFuncionarioIndex(procurarCpf);
                                        if (cpfExiste == -1)
                                        {
                                            Console.WriteLine(".------------------------------------.");
                                            Console.WriteLine("|   RESPONSÁVEL NÃO ENCONTRADO!      |");
                                            Console.WriteLine("'------------------------------------'");
                                            Task.Delay(3000).Wait();
                                            Console.Clear();
                                        
                                        }
                                        else
                                        {
                                            animalList[procurar].responsavel = responsavelList[cpfExiste];
                                            Console.WriteLine(".------------------------------------.");
                                            Console.WriteLine("| RESPONSÁVEL ATUALIZADO COM SUCESSO!|");
                                            Console.WriteLine("'------------------------------------'");
                                            Task.Delay(3000).Wait();
                                            Console.Clear();
                                            
                                        }
                                        break;
                                    case 5:
                                        Console.WriteLine($"O cep do local é {animalList[procurar].localizacao.cep}");
                                        Console.WriteLine("Qual o cep do novo lugar?");
                                        long procurarCep = long.Parse(Console.ReadLine());
                                        int cepExiste = ProcurarLarIndex(procurarCep);
                                        if (cepExiste == -1)
                                        {
                                            Console.WriteLine(".------------------------------------.");
                                            Console.WriteLine("|       LOCAL NÃO ENCONTRADO!        |");
                                            Console.WriteLine("'------------------------------------'");
                                            Task.Delay(3000).Wait();
                                            Console.Clear();
                                            
                                        }
                                        else
                                        {
                                            animalList[procurar].localizacao = larList[cepExiste];
                                            Console.WriteLine(".------------------------------------.");
                                            Console.WriteLine("|   LOCAL ATUALIZADO COM SUCESSO!    |");
                                            Console.WriteLine("'------------------------------------'");
                                            Task.Delay(3000).Wait();
                                            Console.Clear();
                                            
                                        }
                                        break;
                                    case 6:
                                        Console.WriteLine(".------------------------------------.");
                                        Console.WriteLine("|      VOLTANDO AO MENU INICIAL      |");
                                        Console.WriteLine("'------------------------------------'");
                                        Task.Delay(3000).Wait();
                                        Console.Clear();
                                        break;

                                    default:
                                        Console.WriteLine("Opção inválida.");
                                        break;
                                }
                            } while (escolha != 6);
                        }
                        break;
                        break;
                    case 3:
                        MenuCadastroLar();
                        int selecaoLar = int.Parse(Console.ReadLine());
                        if (selecaoLar == 1)
                        {
                            larList.Add(CadastroDeLar("LarPermanente"));
                            Console.WriteLine(".------------------------------------.");
                            Console.WriteLine("| CADASTRO DE LAR FEITO COM SUCESSO! |");
                            Console.WriteLine("'------------------------------------'");
                            Task.Delay(3000).Wait();
                            Console.Clear();
                            
                        }
                        else
                        {
                            larList.Add(CadastroDeLar("LarTemporario"));
                            Console.WriteLine(".------------------------------------.");
                            Console.WriteLine("| CADASTRO DE LAR FEITO COM SUCESSO! |");
                            Console.WriteLine("'------------------------------------'");
                            Task.Delay(3000).Wait();
                            Console.Clear();
                        }
                        break;
                    case 4:
                        Console.WriteLine($"Digite o CEP do lar que você deseja atualizar (apenas números):");
                        long cep2 = int.Parse(Console.ReadLine());
                        int index4 = ProcurarLarIndex(cep2);
                        if (index4 == -1)
                        {
                            Console.WriteLine(".------------------------------------.");
                            Console.WriteLine("|  LOCAL NÃO ENCONTRADO NO SISTEMA!  |");
                            Console.WriteLine("'------------------------------------'");
                        }
                        else
                        {
                            MenuAtualizacaoLar(larList[index4]);
                            Console.WriteLine(".------------------------------------.");
                            Console.WriteLine("|    LAR ATUALIZADO COM SUCESSO!     |");
                            Console.WriteLine("'------------------------------------'");
                            
                            for (int i1 = 0; i1 < animalList.Count - 1; i1++)
                            {
                                if (animalList[i1].localizacao.cep == cep2)
                                {
                                    animalList[i1].localizacao = larList[index4];
                                }

                            }
                        }
                        Console.WriteLine("Redirecionando a página inicial...");
                        Task.Delay(3000).Wait();
                        Console.Clear();
                        break;
                    case 5:
                        responsavelList.Add(MenuCadastroPessoa());
                        break;
                    case 6:
                        Console.WriteLine("Digite o cpf da pessoa que você deseja atualizar os dados:");
                        long funcionarioCPF = long.Parse(Console.ReadLine());
                        int index3 = ProcurarFuncionarioIndex(funcionarioCPF);
                        if (index3 == -1)
                        {
                            Console.WriteLine("Pessoa não registrada no sistema.");
                        }
                        else
                        {
                            MenuAtualizacaoPessoa(responsavelList[index3]);
                            for (int i1 = 0; i1 < animalList.Count - 1; i1++)
                            {
                                if (animalList[i1].responsavel.cpf == funcionarioCPF)
                                {
                                    animalList[i1].responsavel = responsavelList[index3];
                                }

                            }
                        }
                        Task.Delay(3000).Wait();
                        Console.Clear();
                        break;
                    case 7:
                        string opcao = "";

                        do 
                        {
                            Console.WriteLine("Digite o nome do animal:");
                            string nome = Console.ReadLine();
                            int i = ProcurarAnimalNome(nome);
                            if (i == -1)
                            {
                                Console.WriteLine("Animal não registrado no sistema.");
                            }
                            else 
                            {
                                Console.Clear();
                                animalList[i].ImprimirDados();
                                Console.WriteLine(" ");
                                animalList[i].localizacao.DadosLar();
                                Console.WriteLine(" ");
                                animalList[i].responsavel.DadosResponsavel();
                                Console.WriteLine(" ");                                
                            }
                            Console.Write("Você deseja consultar outro animal? ");
                            opcao = Console.ReadLine();
                            Console.Clear();

                        } while (opcao.ToUpper() != "N");

                        Console.WriteLine("Redirecionando a página inicial...");
                        Task.Delay(3000).Wait();
                        Console.Clear();

                        break;
                    case 8:
                        Console.Clear();
                        Console.WriteLine("Programa finalizado.");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }

            } while (selecao != 8);
            

            
            int ProcurarAnimalNome(string nome)
            {
                for (int i = 0; i < animalList.Count; i++)
                {
                    if (animalList[i].nome.ToUpper().Equals(nome.ToUpper()))
                    {
                        return i;
                    }
                }
                return -1;
            }

        

            bool ProcurarLar(long cep)
            {
                for (int i = 0; i < larList.Count; i++)
                {
                    if (larList[i].cep.Equals(cep))
                    {
                        return true;
                    }
                }
                return false;
            }

            int ProcurarLarIndex(long cep)
            {
                for (int i = 0; i < larList.Count; i++)
                {
                    if (larList[i].cep.Equals(cep))
                    {
                        return i;
                    }
                }
                return -1;
            }

            bool ProcurarFuncionario(long cpf)
            {
                for (int i = 0; i < larList.Count; i++)
                {
                    if (responsavelList[i].cpf.Equals(cpf))
                    {
                        return true;
                    }
                }
                return false;
            }

            int ProcurarFuncionarioIndex(long cpf)
            {
                for (int i = 0; i < larList.Count; i++)
                {
                    if (responsavelList[i].cpf.Equals(cpf))
                    {
                        return i;
                    }
                }
                return -1;
            }
        }


        public static void Menu()
        {
            Console.WriteLine("___________PROJETO ADOTE ©___________");
            Console.WriteLine("|O que você gostaria de fazer?       |");
            Console.WriteLine("|------------------------------------|");
            Console.WriteLine("|1- Cadastrar novo animal            |");
            Console.WriteLine("|2- Atualizar os dados de um animal  |");
            Console.WriteLine("|3- Cadastrar novo endereço          |");
            Console.WriteLine("|4- Atualizar um endereço            |");
            Console.WriteLine("|5- Cadastrar nova pessoa            |");
            Console.WriteLine("|6- Atualizar dados de uma pessoa    |");
            Console.WriteLine("|7- Consultar Dados Gerais           |");
            Console.WriteLine("|8- SAIR                             |");
            Console.WriteLine("'------------------------------------'");
            Console.Write("ESCOLHA SUA OPÇÃO: ");

            

            //CONSULTAR DADOS!

        }

        public static void MenuCadastroAnimal()
        {
            Console.WriteLine("|--------- PROJETO ADOTE © ----------|");
            Console.WriteLine("|         CADASTRO DE ANIMAL         |");
            Console.WriteLine("'------------------------------------'");
            Console.WriteLine("Qual animal você gostaria de cadastrar?");
            Console.WriteLine("|------------------------------------|");
            Console.WriteLine("|1- Cachorro                         |");
            Console.WriteLine("|2- Gato                             |");
            Console.WriteLine("|3- Roedor                           |");
            Console.WriteLine("'------------------------------------'");
            Console.Write("ESCOLHA SUA OPÇÃO: ");
        }

        public static Animal MenuCadastroNovoAnimal(string tipoDeAnimal)
        {
            Console.WriteLine( "|--------- PROJETO ADOTE © ----------|");
            Console.WriteLine($"ºCADASTRANDO UM NOVO {tipoDeAnimal.ToUpper()} NA ONG º");
            Console.WriteLine( "|------------------------------------|");
            Console.Write($"1. Qual o nome do {tipoDeAnimal}? ");
            string nome = Console.ReadLine();
            Console.WriteLine( "|------------------------------------|");
            Console.Write($"2. Qual a idade do {tipoDeAnimal}? ");
            int idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( "|------------------------------------|");
            Console.Write($"3. Qual o sexo do {tipoDeAnimal}? \nF - Fêmea ou M - Macho: ");
            string sexo = Console.ReadLine();
            Console.WriteLine("|------------------------------------|");
            Console.Write($"4. Qual a cor do {tipoDeAnimal}? ");
            string cor = Console.ReadLine();
            Console.WriteLine("|------------------------------------|");
            Console.Write("5. Ele já está vacinado? \nS - SIM ou N - NÃO: ");
            string vacinado = Console.ReadLine();
            bool vacinasEmDia = vacinado.ToUpper() == "S" ? true : false;
            Console.WriteLine("|------------------------------------|");
            Console.Write(" 6. Ele está doente?\nS - SIM ou N - NÃO: ");
            string doente = Console.ReadLine();
            bool animalDoente = doente.ToUpper() == "S" ? true : false;
            Console.WriteLine("|------------------------------------|");

            if (tipoDeAnimal == "cachorro")
            {
                Console.Write($"7. Qual a raça do {tipoDeAnimal}? ");
                string raca = Console.ReadLine();
                Console.WriteLine("|------------------------------------|");
                Console.Write($"8. Qual o porte do {tipoDeAnimal}?\nP- Pequeno M- Médio G- Grande: ");
                string porte = Console.ReadLine();
                Console.WriteLine("|------------------------------------|");
                Console.Write("9. Ele aceita outro animal?\nS - SIM ou N - NÃO: ");
                string sociavel = Console.ReadLine();
                bool aceitaCompanhia = sociavel.ToUpper() == "S" ? true : false;
                Console.WriteLine("'------------------------------------'");

                Cao cachorro = new Cao();
                int id = DefinirID();
                cachorro.id = id;
                cachorro.nome = nome;
                cachorro.sexo = sexo;
                cachorro.idade = idade;
                cachorro.cor = cor;
                cachorro.adotado = false;
                cachorro.vacinado = vacinasEmDia;
                cachorro.doente = animalDoente;
                cachorro.raca = raca;
                cachorro.porte = porte;
                cachorro.aceitaOutroAnimal = aceitaCompanhia;
                Console.WriteLine($"\nAnimal {nome} cadastrado com sucesso com nº de ID de {id}.");
                return cachorro;
            }
            else if (tipoDeAnimal == "gato")
            {
                Console.Write($"7. Qual a raça do {tipoDeAnimal}?");
                string raca = Console.ReadLine();
                Console.WriteLine("|------------------------------------|");
                Console.Write("8. Qual o comprimento pelagem dele? \nC- Curto M- Médio G - Grande: ");
                string pelagem = Console.ReadLine();
                Console.WriteLine("|------------------------------------|");
                Console.Write("Ele aceita outro animal?\nS - SIM ou N - NÃO: ");
                string sociavel = Console.ReadLine();
                bool aceitaCompanhia = sociavel.ToUpper() == "S" ? true : false;
                Console.WriteLine("'------------------------------------'");

                Gato gato = new Gato();
                int id = DefinirID();
                gato.id = id;
                gato.nome = nome;
                gato.sexo = sexo;
                gato.idade = idade;
                gato.cor = cor;
                gato.adotado = false;
                gato.vacinado = vacinasEmDia;
                gato.doente = animalDoente;
                gato.raca = raca;
                gato.pelagem = pelagem;
                gato.aceitaOutroAnimal = aceitaCompanhia;
                Console.WriteLine($"\nAnimal {nome} cadastrado com sucesso com nº de ID de {id}");
                return gato;
            }
            else
            {
                Console.Write("7. Qual o tipo dele? ");
                string tipo = Console.ReadLine();
                Console.WriteLine("|------------------------------------|");
                Console.Write("8. Ele precisa de companhia?\nS - SIM ou N - NÃO: ");
                string sociavel = Console.ReadLine();
                bool aceitaCompanhia = sociavel.ToUpper() == "S" ? true : false;
                Console.WriteLine("'------------------------------------'");

                Roedor roedor = new Roedor();
                int id = DefinirID();
                roedor.id = id;
                roedor.nome = nome;
                roedor.sexo = sexo;
                roedor.idade = idade;
                roedor.cor = cor;
                roedor.adotado = false;
                roedor.vacinado = vacinasEmDia;
                roedor.doente = animalDoente;
                roedor.tipo = tipo;
                roedor.precisaDeCompanhia = aceitaCompanhia;
                Console.WriteLine($"\nAnimal {nome} cadastrado com sucesso com nº de ID de {id}");
                return roedor;
            }



        }

        public static int DefinirID()
        {
            Random rd = new Random();
            int rand_num = rd.Next(10000, 20000);
            return rand_num;
        }

        public static Lar CadastroDeLar(string tipoDeLar)
        {
            if(tipoDeLar == "LarTemporario")
            {
                Console.WriteLine("\n|--------- PROJETO ADOTE © ----------|");
                Console.WriteLine("|     CADASTRO DE LAR TEMPORÁRIO     |");
                Console.WriteLine("'------------------------------------'");
                LarTemporario lar = new LarTemporario();
                Console.Write("Qual o nome do lar? ");
                string nome = Console.ReadLine();
                Console.WriteLine("|------------------------------------|");
                Console.WriteLine("|               ENDEREÇO             |");
                Console.WriteLine("'------------------------------------'");
                Console.Write("LOGRADOURO: ");
                string rua = Console.ReadLine();
                Console.Write("Nº: ");
                int numero = int.Parse(Console.ReadLine());
                Console.Write("COMPLEMENTO: ");
                string complemento = Console.ReadLine();
                Console.Write("CIDADE: ");
                string cidade = Console.ReadLine();
                Console.Write("ESTADO: ");
                string estado = Console.ReadLine();
                Console.Write("CEP: ");
                int cep = int.Parse(Console.ReadLine());
                Console.WriteLine("'------------------------------------'");
                lar.nomeDoLar = nome;
                lar.rua = rua;
                lar.numero = numero;
                lar.complemento = complemento;
                lar.cidade = cidade;
                lar.estado = estado;
                lar.cep = cep;

                return lar;

            }
            else
            {
                Console.WriteLine("\n.--------- PROJETO ADOTE © ----------.");
                Console.WriteLine(  "|     CADASTRO DE LAR PERMANENTE     |");
                Console.WriteLine(  "'------------------------------------'");
                LarPermanente lar = new LarPermanente();
                Console.WriteLine(".------------------------------------.");
                Console.WriteLine("|               ENDEREÇO             |");
                Console.WriteLine("'------------------------------------'");
                Console.Write("LOGRADOURO: "); ;
                string rua = Console.ReadLine();
                Console.Write("Nº: ");
                int numero = int.Parse(Console.ReadLine());
                Console.Write("COMPLEMENTO: ");
                string complemento = Console.ReadLine();
                Console.Write("CIDADE: ");
                string cidade = Console.ReadLine();
                Console.Write("ESTADO: ");
                string estado = Console.ReadLine();
                Console.Write("CEP: ");
                int cep = int.Parse(Console.ReadLine());
                Console.WriteLine("'------------------------------------'");
                lar.rua = rua;
                lar.numero = numero;
                lar.complemento = complemento;
                lar.cidade = cidade;
                lar.estado = estado;
                lar.cep = cep;

                return lar;
            }
        }

        public static void MenuAtualizacaoAnimal()
        {
            Console.WriteLine("___________PROJETO ADOTE ©___________");
            Console.WriteLine("|O que você gostaria de atualizar?   |");
            Console.WriteLine("|------------------------------------|");
            Console.WriteLine("|1- Status da adoção                 |");
            Console.WriteLine("|2- Status de Vacinado               |");
            Console.WriteLine("|3- Status de doente                 |");
            Console.WriteLine("|4- Quem é o responsável             |");
            Console.WriteLine("|5- Em que local ele está            |");
            Console.WriteLine("|6- SAIR                             |");
            Console.WriteLine("'------------------------------------'");
            Console.Write("ESCOLHA SUA OPÇÃO: ");
        }

        public static void MenuCadastroLar()
        {
            Console.WriteLine("_________________PROJETO ADOTE ©_________________");
            Console.WriteLine("|Qual tipo de lar você gostaria de cadastrar?   |");
            Console.WriteLine("|-----------------------------------------------|");
            Console.WriteLine("|1- Lar Permanente                              |");
            Console.WriteLine("|2- Lar Temporário                              |");
            Console.WriteLine("'-----------------------------------------------'");
            Console.Write("ESCOLHA SUA OPÇÃO: ");
        }

        public static void MenuAtualizacaoLar(Lar lar)
        {
            Console.WriteLine($"Registro encontrado!\n");
            Console.WriteLine("___________PROJETO ADOTE ©___________");
            Console.WriteLine($"\nAtualização dos dados do CEP: {lar.cep}");
            Console.WriteLine("'------------------------------------'");
            Console.Write(" ~Qual o novo CEP? ");
            int cep = int.Parse(Console.ReadLine());
            Console.Write(" ~Qual o novo nome da rua? ");
            string rua = Console.ReadLine();
            Console.Write(" ~Qual o novo número? ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write(" ~Qual o novo complemento? ");
            string complemento = Console.ReadLine();
            Console.WriteLine(" ~Ainda está na mesma cidade?");
            Console.WriteLine("S - Sim");
            Console.WriteLine("N - Não");
            string cidadeDiferente = Console.ReadLine();
            if (cidadeDiferente.ToUpper() == "N")
            {
                Console.Write(" ~Está em qual cidade? ");
                string cidade = Console.ReadLine();
                Console.Write(" ~Está em qual estado? ");
                string estado = Console.ReadLine();
                lar.cidade = cidade;
                lar.estado = estado;
            }
            
            lar.rua = rua;
            lar.numero = numero;
            lar.complemento = complemento;
            lar.cep = cep;
        }

        public static Responsavel MenuCadastroPessoa()
        {
            Console.WriteLine("______________PROJETO ADOTE ©______________");
            Console.WriteLine("|qual pessoa você gostaria de cadastrar?   |");
            Console.WriteLine("|------------------------------------------|");
            Console.WriteLine("|1- Adotante                               |");
            Console.WriteLine("|2- Funcionário                            |");
            Console.WriteLine("'------------------------------------------'");
            Console.Write("ESCOLHA SUA OPÇÃO: ");

            int resposta = Convert.ToInt32(Console.ReadLine());

            if (resposta == 1)
            {
                return MenuCadastroNovoAdotante();
            }
            else
            {
                return MenuCadastroNovoGerente();
            }
                   

        }
        public static Responsavel MenuCadastroNovoAdotante()
        {
            Console.WriteLine(".------------------------------------.");
            Console.WriteLine("|          CADASTRO ADOTANTE         |");
            Console.WriteLine("'------------------------------------'");
            Console.Write("NOME: ");
            string nome = Console.ReadLine();
            Console.Write("IDADE: ");
            int idade = Convert.ToInt32(Console.ReadLine());
            Console.Write("RG: ");
            long rg = Convert.ToInt64(Console.ReadLine());
            Console.Write("CPF: ");
            long cpf = Convert.ToInt64(Console.ReadLine());
            Console.Write("TELEFONE: ");
            string telefoneContato = Console.ReadLine();
            Console.Write("E-MAIL: ");
            string emailContato = Console.ReadLine();
            Console.Write("CEP: ");
            long cepLarPermanente = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("\n.------------------------------------.");
            Console.WriteLine("|         Outras informações...      |");
            Console.WriteLine("'------------------------------------'");
            Console.WriteLine("O adotante já enviou o comprovante de residência?");
            Console.WriteLine("S- SIM");
            Console.WriteLine("N- NÃO");
            string resposta1 = Console.ReadLine();
            Console.WriteLine("O adotante já enviou o Termo de Responsabilidade assinado?");
            Console.WriteLine("S- SIM");
            Console.WriteLine("N- NÃO");
            string resposta2 = Console.ReadLine();

            Console.WriteLine(".------------------------------------.");
            Console.WriteLine("|  ADOTANTE CADASTRADO COM SUCESSO!  |");
            Console.WriteLine("'------------------------------------'");
            Task.Delay(3000).Wait();
            Console.Clear();

            Adotante adotante = new Adotante();

            adotante.nome = nome;
            adotante.idade = idade;
            adotante.rg = rg;
            adotante.cpf = cpf;
            adotante.telefoneContato = telefoneContato;
            adotante.emailContato = emailContato;
            adotante.cepLarPermanente = cepLarPermanente;
            if (resposta1.ToUpper() == "S")
                adotante.comprovanteResidenciaOK = true;
            else
                adotante.comprovanteResidenciaOK = false;
            if (resposta2.ToUpper() == "S")
                adotante.termoDeResponsabilidadeOK = true;
            else
                adotante.termoDeResponsabilidadeOK = false;

            adotante.analiseDocumentos();
            
            return adotante;
        }

        public static Responsavel MenuCadastroNovoGerente()
        {
            Console.WriteLine(".------------------------------------.");
            Console.WriteLine("|           CADASTRO GERENTE         |");
            Console.WriteLine("'------------------------------------'");
            Console.Write("NOME: ");
            string nome = Console.ReadLine();
            Console.Write("IDADE: ");
            int idade = Convert.ToInt32(Console.ReadLine());
            Console.Write("RG: ");
            long rg = Convert.ToInt64(Console.ReadLine());
            Console.Write("CPF: ");
            long cpf = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("\n.------------------------------------.");
            Console.WriteLine("|    Informações sobre o abrigo      |");
            Console.WriteLine("'------------------------------------'");
            Console.Write("TELEFONE: ");
            string telefoneContato = Console.ReadLine();
            Console.Write("EMAIL: ");
            string emailContato = Console.ReadLine();
            Console.Write("CEP: ");
            long cepUnidadeONG = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine(".------------------------------------.");
            Console.WriteLine("|   GERENTE CADASTRADO COM SUCESSO!  |");
            Console.WriteLine("'------------------------------------'");
            Task.Delay(3000).Wait();
            Console.Clear();

            GerenteONG gerente = new GerenteONG();
            

            gerente.nome = nome;
            gerente.idade = idade;
            gerente.rg = rg;
            gerente.cpf = cpf;
            gerente.telefoneContato = telefoneContato;
            gerente.emailContato = emailContato;
            gerente.cepUnidadeONG = cepUnidadeONG;

            
            return gerente;
        }
    

    public static void MenuAtualizacaoPessoa(Responsavel responsavel)
        {
            Console.WriteLine("___________PROJETO ADOTE ©________________");
            Console.WriteLine($"\nAtualização dos dados de: {responsavel.nome}");
            Console.WriteLine("'-----------------------------------------'");
            Console.WriteLine($"O número de telefone registrado é {responsavel.telefoneContato}, está correto?");
            Console.WriteLine("S - Sim");
            Console.WriteLine("N - Não");
            string telefone = Console.ReadLine();
            if (telefone.ToUpper() == "N")
            {
                Console.Write("NOVO TELEFONE: ");
                string novotelefone = Console.ReadLine();
                responsavel.telefoneContato = novotelefone;
                Console.WriteLine(".------------------------------------.");
                Console.WriteLine("|  TELEFONE ATUALIZADO COM SUCESSO!  |");
                Console.WriteLine("'------------------------------------'");
            }
            Console.WriteLine($"\nO email de contato registrado é {responsavel.emailContato}, está correto?");
            Console.WriteLine("S - Sim");
            Console.WriteLine("N - Não");
            string email = Console.ReadLine();
            if (email.ToUpper() == "N")
            {
                Console.Write("NOVO EMAIL: ");
                string novoemail = Console.ReadLine();
                responsavel.emailContato = novoemail;
                Console.WriteLine(".------------------------------------.");
                Console.WriteLine("|   E-MAIL ATUALIZADO COM SUCESSO!   |");
                Console.WriteLine("'------------------------------------'");
            }
            Console.WriteLine("Redirecionando a tela inicial...");
            
        }

        public static Animal GeracaoDeAnimaisCao1()
        {
            Cao cachorro = new Cao();
            int id = DefinirID();
            cachorro.id = id;
            cachorro.nome = "Ludmila";
            cachorro.idade = 4;
            cachorro.sexo = "F";
            cachorro.cor = "Caramelo";
            cachorro.adotado = false;
            cachorro.vacinado = true;
            cachorro.doente = true;
            cachorro.raca = "SRD";
            cachorro.porte = "M";
            cachorro.aceitaOutroAnimal = false;
            cachorro.localizacao = GeracaoDeLarTemporario2();
            cachorro.responsavel = GeracaoDeResponsavel1();
            return cachorro;

        }

        public static Animal GeracaoDeAnimaisCao2()
        {
            Cao cachorro1 = new Cao();
            int id = DefinirID();
            cachorro1.id = id;
            cachorro1.nome = "Pipoquinha";
            cachorro1.idade = 0;
            cachorro1.sexo = "M";
            cachorro1.cor = "Branco e preto";
            cachorro1.adotado = false;
            cachorro1.vacinado = false;
            cachorro1.doente = true;
            cachorro1.raca = "SRD";
            cachorro1.porte = "P";
            cachorro1.aceitaOutroAnimal = true;
            cachorro1.localizacao = GeracaoDeLarTemporario2();
            cachorro1.responsavel = GeracaoDeResponsavel1();

            return cachorro1;
        }

        public static Animal GeracaoDeAnimaisCao3()
        {
            Cao cachorro3 = new Cao();
            int id = DefinirID();
            cachorro3.id = id;
            cachorro3.nome = "Friorento";
            cachorro3.idade = 2;
            cachorro3.sexo = "M";
            cachorro3.cor = "Cinza e Branco";
            cachorro3.adotado = false;
            cachorro3.vacinado = true;
            cachorro3.doente = false;
            cachorro3.raca = "Husky Siberiano";
            cachorro3.porte = "G";
            cachorro3.aceitaOutroAnimal = false;
            cachorro3.localizacao = GeracaoDeLarTemporario();
            cachorro3.responsavel = GeracaoDeResponsavel2();

            return cachorro3;
        }

        public static Animal GeracaoDeAnimaisCao4()
        {
            Cao cachorro4 = new Cao();
            int id = DefinirID();
            cachorro4.id = id;
            cachorro4.nome = "Bob";
            cachorro4.sexo = "M";
            cachorro4.idade = 7;
            cachorro4.cor = "Caramelo";
            cachorro4.adotado = false;
            cachorro4.vacinado = false;
            cachorro4.doente = true;
            cachorro4.raca = "SRD";
            cachorro4.porte = "G";
            cachorro4.aceitaOutroAnimal = false;
            cachorro4.localizacao = GeracaoDeLarTemporario2();
            cachorro4.responsavel = GeracaoDeResponsavel1();

            return cachorro4;
        }

        public static Animal GeracaoDeAnimaisGato1()
        {
            Gato gato = new Gato();
            int id = DefinirID();
            gato.id = id;
            gato.nome = "Pluma";
            gato.sexo = "F";
            gato.idade = 4;
            gato.cor = "Branco";
            gato.adotado = false;
            gato.vacinado = true;
            gato.doente = true;
            gato.raca = "Persa";
            gato.pelagem = "L";
            gato.aceitaOutroAnimal = true;
            gato.localizacao = GeracaoDeLarTemporario2();
            gato.responsavel = GeracaoDeResponsavel1();
            return gato;
        }


        public static Animal GeracaoDeAnimaisGato2()
        {
            Gato gato = new Gato();
            int id = DefinirID();
            gato.id = id;
            gato.nome = "Universo";
            gato.sexo = "M";
            gato.idade = 8;
            gato.cor = "Preto";
            gato.adotado = false;
            gato.vacinado = false;
            gato.doente = false;
            gato.raca = "SRD";
            gato.pelagem = "M";
            gato.aceitaOutroAnimal = false;
            gato.localizacao = GeracaoDeLarTemporario();
            gato.responsavel = GeracaoDeResponsavel2();
            return gato;
        }

        public static Animal GeracaoDeAnimaisRoedor()
        {
            Roedor roedor = new Roedor();
            int id = DefinirID();
            roedor.id = id;
            roedor.nome = "Páscoa";
            roedor.sexo = "M";
            roedor.idade = 1;
            roedor.cor = "Marrom";
            roedor.adotado = false;
            roedor.vacinado = true;
            roedor.doente = false;
            roedor.tipo = "Coelho";
            roedor.precisaDeCompanhia = false;
            roedor.localizacao = GeracaoDeLarTemporario();
            roedor.responsavel = GeracaoDeResponsavel2();
            return roedor;
        }

        public static Lar GeracaoDeLarTemporario()
        {
            LarTemporario lar = new LarTemporario();
            lar.nomeDoLar = "Canil Let's code";
            lar.rua = "Av. Bem-te-vi";
            lar.numero = 335;
            lar.complemento = "Em frente a igreja Presbiteriana";
            lar.cidade = "São Paulo";
            lar.estado = "SP";
            lar.cep = 04514040;
            return lar;
        }

        public static Lar GeracaoDeLarTemporario2()
        {
            LarTemporario lar = new LarTemporario();
            lar.nomeDoLar = "Clínica Veterinária 853' ";
            lar.rua = "Av. Marília";
            lar.numero = 12;
            lar.complemento = "Ao lado do Restaurante Boa Refeição";
            lar.cidade = "São Paulo";
            lar.estado = "SP";
            lar.cep = 01311589;
            return lar;
        }

        public static Responsavel GeracaoDeResponsavel1()
        {
            GerenteONG gerente = new GerenteONG();
            gerente.nome = "Amanda Mantovani";
            gerente.idade = 32;
            gerente.telefoneContato = "32119850";
            gerente.emailContato = "amandamantovani@ong.com.br";
            gerente.rg = 125478965;
            gerente.cpf = 52589632541;
            return gerente;
        }

        public static Responsavel GeracaoDeResponsavel2()
        {
            GerenteONG gerente = new GerenteONG();
            gerente.nome = "Michael Tadeu";
            gerente.idade = 27;
            gerente.telefoneContato = "34256879";
            gerente.emailContato = "michaeltadeu@ong.com.br";
            gerente.rg = 158964855;
            gerente.cpf = 02589632511;
            return gerente;
        }

    }
}
