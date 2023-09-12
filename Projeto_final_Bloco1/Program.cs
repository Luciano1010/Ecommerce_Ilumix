using Projeto_final_Bloco1.Controller;
using Projeto_final_Bloco1.Model;
using System.Security.Cryptography.X509Certificates;

namespace Projeto_final_Bloco1
{
    public class Program
    {
        private static ConsoleKeyInfo consoleKeyInfo;
        static void Main(string[] args)
        {
            int opcao = 0;
            string? cor, material, formato, nome;
            string tamanho;
            int numero = 0;
            int id;
            int tipo;
            int led;
            int preco;
            string florescente;


            LuminariaController luminaria = new();

           
      

           
           

            Console.Clear();



            Abertura();
            while (true)
            {

                Console.WriteLine("***********************************");
                Console.WriteLine("                                   ");
                Console.WriteLine("               ILUMIX              ");
                Console.WriteLine("         Casa das Luminarias       ");
                Console.WriteLine("                                   ");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("Digite Opção Desejada              ");
                Console.WriteLine("                                   ");
                Console.WriteLine("        1 - Criar Luminaria        ");
                Console.WriteLine("        2 - Lista de Produtos      ");
                Console.WriteLine("        3 - Buscar Produto         ");
                Console.WriteLine("        4 - Deletar Produto        ");
                Console.WriteLine("        5 - Sair                   ");
                Console.WriteLine("-----------------------------------");

                try { 
                opcao = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();
                    switch (opcao)
                    {


                        case 1:

                            

                            Console.WriteLine("Digite o tipo da luminaria: ");
                            tipo =Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Tamanho da luminaria; ");
                            tamanho = Console.ReadLine();

                            Console.WriteLine("Qual formato Desejado");
                            formato = Console.ReadLine();   
                            
                            Console.WriteLine("Digite a cor desejada");
                            cor = Console.ReadLine();

                            Console.WriteLine("O preço final: ");
                            preco = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Qual o nome que deseja cadastrar: ");
                            nome = Console.ReadLine();
                           


                            switch (tipo) 
                            {
                                case 1:
                                    Console.WriteLine("Digite o Modelo de Led:");
                                    led = Convert.ToInt32(Console.ReadLine());
                                    Led l1 = new Led(tamanho, formato, cor, preco, led, luminaria.GerarNumero(),nome);
                                    luminaria.CriarProduto(l1);
                                    KeyPress();
                                    break;
                                case 2:
                                    Console.WriteLine("Digite o Modelo da Luminaria Florescente: ");
                                    florescente = Console.ReadLine();
                                    Florescentes l2 = new Florescentes(tamanho, formato, cor, preco, florescente, luminaria.GerarNumero(), nome);
                                    luminaria.CriarProduto(l2);
                                    KeyPress(); 
                                    break;
                            }
                            Console.Clear();
                            break;


                        case 2:
                           
                            Console.WriteLine("Lista de Produtos ");
                            luminaria.ListarLuminarias();
                            KeyPress();
                            Console.Clear();
                            break;
                            

                        case 3:

                         
                            Console.WriteLine("Digite o Id de Busca");
                            numero = Convert.ToInt32(Console.ReadLine());
                            luminaria.ProcurarId(numero);

                            KeyPress();
                            Console.Clear();
                            break;

                        case 4:
                            Console.WriteLine("Digite o Id Para Deletar o Produto");
                            id= Convert.ToInt32(Console.ReadLine());  
                            luminaria.Deletar(id);
                            

                            KeyPress();
                            Console.Clear();
                               
                            break;

                        case 5:

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Programa finalizado....");
                            Sobre();
                            System.Environment.Exit(0);
                            
                            
                            break;

                        default:

                            Console.WriteLine("Opção Invalida");
                            break;
                    }
                }catch(FormatException) 
                {
                    Console.WriteLine(" Digite uma Opção Existente ");
                    KeyPress();
                    
                }
           
            }

        }

                    
                      
        public static void KeyPress()
        {
            do
            {
                Console.Write("\nPressione Enter para Continuar...");
                consoleKeyInfo = Console.ReadKey();
            } while (consoleKeyInfo.Key != ConsoleKey.Enter);
        }

        public static void Abertura() 
        {        
        
           Console.WriteLine("***********************************");
           Console.WriteLine("           SEJA BEM VINDO          ");
           Console.WriteLine("                 A                 ");
           Console.WriteLine("               ILUMIX              ");
           Console.WriteLine("***********************************");

        
        }
    
        public static void Sobre() 
        {
            Console.WriteLine("*******************************************");
            Console.WriteLine("Projeto Desenvolvido por Luciano Simões    ");
            Console.WriteLine("Email - luciano_lopesdealmdeida@hotmail.com");
            Console.WriteLine("github - https://github.com/Luciano1010    ");
            Console.WriteLine("*******************************************");
            
        
        }
    }








                              

                                

                           
                            









}
            
            




