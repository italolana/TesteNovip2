using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using static TesteNovip2.Program;

namespace TesteNovip2
{
    internal class Program
    {

        public class Cliente
        {
            public string Nome { get; set; }
            public string CPF { get; set; }
            public string DataCadastro { get; set; }
            public string DataNascimento { get; set; }
            public List<string> Telefones { get; set; }            
            public string RG { get; set; }

            public Cliente(string Nome, string Cpf, string DataCadastro, string DataNascimento, List<string> Telefones, string RG)
            {
                this.Nome = Nome;
                this.CPF = Cpf;
                this.DataCadastro = DataCadastro;
                this.DataNascimento = DataNascimento;
                this.Telefones = Telefones;
                this.RG = RG;

            }
            public Cliente(string Nome, string Cpf, string DataCadastro, string DataNascimento, List<string> Telefones)
            {
                this.Nome = Nome;
                this.CPF = Cpf;
                this.DataCadastro = DataCadastro;
                this.DataNascimento = DataNascimento;
                this.Telefones = Telefones;

            }
        }




        static void Main(string[] args)
        {

            List<Cliente> MeusClientes = new List<Cliente>();
            List<string> Telefones = new List<string>();

            do
            {

            Console.WriteLine("Digite a UF para cadastrar o cliente ou MAIS para outras opções");
            string UF = Console.ReadLine();
            UF = UF.ToUpper();                                       
                            
            if (UF == "SC")
            {

                ClienteSC(MeusClientes, Telefones);


            }
            else if (UF == "PR")
            {

                ClientePR(MeusClientes, Telefones);

            }
            else if(UF =="MAIS")
            {
              Console.WriteLine("---------------------------------------------");
              Console.WriteLine("Digite 0 para ver todos clientes");
              Console.WriteLine("Digite 1 para pesquisar cliente");
              Console.WriteLine("Digite 3 para encerrar aplicação");
              Console.WriteLine("---------------------------------------------");
              string op = Console.ReadLine();

                    if (op == "0")
                    {

                        foreach (var cliente in MeusClientes)
                        {
                            Console.WriteLine("---------------------------------------------");
                            Console.WriteLine($"Nome: {cliente.Nome}");
                            Console.WriteLine($"CPF: {cliente.CPF}");
                            Console.WriteLine($"Data de Cadastro: {cliente.DataCadastro}");
                            Console.WriteLine($"Data de Nascimento: {cliente.DataNascimento}");
                            Console.WriteLine("Telefones:");
                            foreach (var telefone in cliente.Telefones)
                            {
                                Console.WriteLine($"- {telefone}");
                            }

                            if (cliente.RG != null)
                            {
                                Console.WriteLine($"RG: {cliente.RG}");
                            }
                           
                            Console.WriteLine("---------------------------------------------");
                        }


                    }

                    if (op == "1")
                    {
                        Console.WriteLine("---------------------------------------------");
                        Console.WriteLine("1: Buscar por Nome ");
                        Console.WriteLine("2: Buscar por Data de Cadastro ");
                        Console.WriteLine("3: Buscar por Data de Nascimento ");
                        Console.WriteLine("0: Voltar ");
                        Console.WriteLine("---------------------------------------------");
                        string procura = Console.ReadLine();



                        FiltroPesquisa(procura, MeusClientes);



                    }                                    

                    if (op == "3")
                    {
                        break;


                    }

                }

            } while (true);
       
        }

        private static void FiltroPesquisa(string procura, List<Cliente> MeusClientes)
        {


            switch (procura)
            {

                case "1":
                    Console.WriteLine("Digite o nome: ");
                    string n = Console.ReadLine();
                    bool encontrado = false;
                    int cont = MeusClientes.Count;


                  


                    foreach (var cliente in MeusClientes)
                    {
                        cont--;
                     

                        if (cliente.Nome.Contains(n, StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("---------------------------------------------");
                            Console.WriteLine($"Nome: {cliente.Nome}");
                            Console.WriteLine($"CPF: {cliente.CPF}");
                            Console.WriteLine($"Data de Cadastro: {cliente.DataCadastro}");
                            Console.WriteLine($"Data de Nascimento: {cliente.DataNascimento}");
                            Console.WriteLine("Telefones:");
                            foreach (var telefone in cliente.Telefones)
                            {
                                Console.WriteLine($"- {telefone}");
                            }

                            if (cliente.RG != null)
                            {
                                Console.WriteLine($"RG: {cliente.RG}");
                            }

                            Console.WriteLine("---------------------------------------------");


                            encontrado = true;  


                        }
                        if (!encontrado && cont == 0)
                        {
                            Console.WriteLine("Nao encontrado");
                        }
                                                                      

                    }

                    break;

                case "2":

                    Console.WriteLine("Digite a Data de Cadastro: ");
                    string n1 = Console.ReadLine();
                    bool encontrado1 = false;
                    int cont1 = MeusClientes.Count;



                    foreach (var cliente in MeusClientes)
                    {
                        cont1--;


                        if (cliente.DataCadastro.Contains(n1, StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("---------------------------------------------");
                            Console.WriteLine($"Nome: {cliente.Nome}");
                            Console.WriteLine($"CPF: {cliente.CPF}");
                            Console.WriteLine($"Data de Cadastro: {cliente.DataCadastro}");
                            Console.WriteLine($"Data de Nascimento: {cliente.DataNascimento}");
                            Console.WriteLine("Telefones:");
                            foreach (var telefone in cliente.Telefones)
                            {
                                Console.WriteLine($"- {telefone}");
                            }

                            if (cliente.RG != null)
                            {
                                Console.WriteLine($"RG: {cliente.RG}");
                            }

                            Console.WriteLine("---------------------------------------------");

                            encontrado1 = true;



                        }
                        if (!encontrado1 && cont1 == 0)
                        {
                            Console.WriteLine("Nao encontrado");
                        }


                      
                    }


                    break;

                case "3":

                    Console.WriteLine("Digite a Data de Nascimento: ");
                    string n3 = Console.ReadLine();
                    bool encontrado3 = false;
                    int cont3 = MeusClientes.Count;



                    foreach (var cliente in MeusClientes)
                    {
                        cont3--;


                        if (cliente.DataNascimento.Contains(n3, StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine("---------------------------------------------");
                            Console.WriteLine($"Nome: {cliente.Nome}");
                            Console.WriteLine($"CPF: {cliente.CPF}");
                            Console.WriteLine($"Data de Cadastro: {cliente.DataCadastro}");
                            Console.WriteLine($"Data de Nascimento: {cliente.DataNascimento}");
                            Console.WriteLine("Telefones:");
                            foreach (var telefone in cliente.Telefones)
                            {
                                Console.WriteLine($"- {telefone}");
                            }

                            if (cliente.RG != null)
                            {
                                Console.WriteLine($"RG: {cliente.RG}");
                            }

                            Console.WriteLine("---------------------------------------------");

                            encontrado3 = true;


                        }
                        if (!encontrado3 && cont3 == 0)
                        {
                            Console.WriteLine("Nao encontrado");
                        }                                               
                    }

                    break;

                case "0":
                   
                    return;

                default:
                    Console.WriteLine("Opcão invalida, tente novamente!");
                    break;


            }

        }

        private static void ClientePR(List<Cliente> MeusClientes, List<string> Telefones)
        {
       
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Cadastrar Cliente PR");
            Console.WriteLine("--------------------------------------------------------");
            bool controle;


            do
            {

                Console.WriteLine("Digite 0 para sair e 1 para cadastrar cliente");
                string entrada = Console.ReadLine();
                controle = entrada == "1";

                if (controle == false)
                {
                    break;
                }

                Cliente pessoa1 = CadastroComum();


                if (!CalcularIdade(pessoa1.DataNascimento))//se o retorno for false
                {
                    Console.WriteLine("Cliente não pode ser cadastrado, pois é menor de 18 anos.");
                    continue; //cadastrar novamente
                }

                MeusClientes.Add(pessoa1);

                Thread.Sleep(1000);

            } while (true);

        }


        private static Cliente CadastroComum()
        {
            DateTime dataAtual = DateTime.Now;
            string dataFormatada = dataAtual.ToString("dd/MM/yyyy HH:mm:ss");

            Console.WriteLine("Digite o Nome do Cliente: ");
            string Nome = Console.ReadLine();

            Console.WriteLine("Digite o CPF do Cliente: ");
            string Cpf = Console.ReadLine();

            Console.WriteLine("Digite a Data De nascimento do Cliente: ");
            string DataNascimento = Console.ReadLine();


            List<string> Telefones = new List<string>();
            do
            {
                Console.WriteLine("Digite o Telefone do Cliente ou digite 'Sair' para parar: ");
                string telefone = Console.ReadLine();
                telefone = telefone.ToUpper();


                if (telefone.Equals("SAIR", StringComparison.OrdinalIgnoreCase))
                    break;

                Telefones.Add(telefone);
            } while (true);

            return new Cliente(Nome, Cpf, dataFormatada, DataNascimento, Telefones);

        } 

        private static  bool CalcularIdade(string DataNasciemnto)
        {

            DateTime dataAtual = DateTime.Now;
            DateTime calData = DateTime.ParseExact(DataNasciemnto, "dd/MM/yyyy", null);
            int idade = dataAtual.Year - calData.Year;
            

            if (idade==18 && dataAtual.Month < calData.Month || (dataAtual.Month == calData.Month && dataAtual.Day < calData.Day))//calculo de mes
            {
                idade--;
            }

            return idade>=18;
        }

        private static void ClienteSC(List<Cliente> MeusClientes, List<string> Telefones)
        {

            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("Cadastrar Cliente SC");
            Console.WriteLine("--------------------------------------------------------");
            bool controle;


            do
            {

                Console.WriteLine("Digite 0 para sair e 1 para cadastrar cliente");
                string entrada = Console.ReadLine();
                controle = entrada == "1";

                if (controle == false)
                {
                    break;
                }

                Cliente pessoa1 = CadastroComum();
                Console.WriteLine("Digite o RG do Cliente: ");
                pessoa1.RG = Console.ReadLine();
                MeusClientes.Add(pessoa1);

                Thread.Sleep(1000);

            } while (true);

         }
    }

    
}
