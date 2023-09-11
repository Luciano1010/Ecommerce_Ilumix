using Projeto_final_Bloco1.Model;
using System;

namespace Projeto_final_Bloco1
{
    internal class Program
    {
        private static ConsoleKeyInfo consoleKeyInfo;
        static void Main(string[] args)
        {
            int opcao = 0;

            Luminarias luminarias = new Luminarias("1", "perfilado", "Branco", "Led", 1200);
            luminarias.Visualizar();

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


                    switch (opcao)
                    {


                        case 1:

                            Console.WriteLine("Digite a Personazalição da Luminaria:");
                            Console.WriteLine("Luminaria Criada com Sucesso  ");

                            KeyPress();
                            Console.Clear();
                            break;


                        case 2:


                            Console.WriteLine("Lista de Produtos de nosso Catalogo");

                            KeyPress();
                            Console.Clear();
                            break;


                        case 3:


                            Console.WriteLine("Digite a Luminaria a ser buscada");

                            KeyPress();
                            Console.Clear();
                            break;

                        case 4:

                            Console.WriteLine("Produto Deletado..");

                            KeyPress();
                            Console.Clear();
                            break;

                        case 5:

                            Console.WriteLine("A Ilumix agradece sua Visita");

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
    }

}
            
            




