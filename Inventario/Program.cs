using System;
using System.Diagnostics;

namespace InventarioComputador
{
    [DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("=== Menu de Inventário do Computador ===");
                Console.WriteLine("1. Hardware");
                Console.WriteLine("2. Software");
                Console.WriteLine("3. Hardware e Software");
                Console.WriteLine("0. Sair");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        MostrarHardware();
                        break;
                    case "2":
                        MostrarSoftware();
                        break;
                    case "3":
                        MostrarHardwareESoftware();
                        break;
                    case "0":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Pressione qualquer tecla para continuar...");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void MostrarHardware()
        {
            Console.Clear();
            Console.WriteLine("=== Inventário de Hardware ===");
            Console.WriteLine("1. Processador: Intel Core i7");
            Console.WriteLine("2. Memória RAM: 16GB");
            Console.WriteLine("3. Placa de Vídeo: NVIDIA GeForce GTX 1660");
            Console.WriteLine("4. Armazenamento: SSD 512GB");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        static void MostrarSoftware()
        {
            Console.Clear();
            Console.WriteLine("=== Inventário de Software ===");
            Console.WriteLine("1. Sistema Operacional: Windows 10");
            Console.WriteLine("2. Navegador: Google Chrome");
            Console.WriteLine("3. Editor de Texto: Visual Studio Code");
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        static void MostrarHardwareESoftware()
        {
            Console.Clear();
            Console.WriteLine("=== Inventário de Hardware e Software ===");
            MostrarHardware();
            MostrarSoftware();
            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}
