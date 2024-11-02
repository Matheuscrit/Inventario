using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu de Inventário do Computador");
            Console.WriteLine("1. Hardware");
            Console.WriteLine("2. Software");
            Console.WriteLine("3. Hardware e Software");
            Console.WriteLine("0. Sair");
            Console.Write("Escolha uma opção: ");

            string escolha = Console.ReadLine();

            switch (escolha)
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
                    Console.WriteLine("Saindo...");
                    return; // Sai do programa
                default:
                    Console.WriteLine("Opção inválida! Pressione qualquer tecla para tentar novamente.");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void MostrarHardware()
    {
        List<string> hardware = new List<string>
        {
            "Processador: Intel Core i7",
            "Placa Mãe: ASUS ROG Strix",
            "Memória RAM: 16GB",
            "Placa de Vídeo: NVIDIA GeForce GTX 1660"
        };

        Console.Clear();
        Console.WriteLine("Inventário de Hardware:");
        foreach (var item in hardware)
        {
            Console.WriteLine("- " + item);
        }
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void MostrarSoftware()
    {
        List<string> software = new List<string>
        {
            "Sistema Operacional: Windows 10",
            "Navegador: Google Chrome",
            "Editor de Texto: Visual Studio Code",
            "Antivírus: Avast"
        };

        Console.Clear();
        Console.WriteLine("Inventário de Software:");
        foreach (var item in software)
        {
            Console.WriteLine("- " + item);
        }
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void MostrarHardwareESoftware()
    {
        Console.Clear();
        Console.WriteLine("Inventário de Hardware e Software:");
        MostrarHardware();
        MostrarSoftware();
        Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }
}