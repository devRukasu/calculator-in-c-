using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("O que você deseja fazer agora?");
            Console.WriteLine("-------------------------");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Sair");
            Console.WriteLine("-------------------------");

            // Esse comando serve para armazenar a resposta do usuario em uma variavel
            int resposta = Convert.ToInt32(Console.ReadLine());

            switch (resposta)
            {
                case 1: Adicao(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Console.WriteLine("Opção inválida, tente novamente"); Console.ReadLine(); Menu(); break;
            }
        }

        static void Adicao()
        {
            Console.Clear();
            Console.WriteLine("Digite um Numero: ");
            float valor1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite outro Numero: ");
            float valor2 = Convert.ToSingle(Console.ReadLine());

            float resultado = valor1 + valor2;
            Console.WriteLine($"O resultado da soma é: {resultado}");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Pressione Enter para Voltar ao Menu");
            Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();
            Console.WriteLine("Digite um Numero: ");
            float valor1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite outro Numero: ");
            float valor2 = Convert.ToSingle(Console.ReadLine());

            float resultado = valor1 - valor2;
            Console.WriteLine($"O resultado da subtração é: {resultado}");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Pressione Enter para Voltar ao Menu");
            Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Digite um Numero: ");
            float valor1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite outro Numero: ");
            float valor2 = Convert.ToSingle(Console.ReadLine());

            float resultado = valor1 / valor2;
            Console.WriteLine($"O resultado da soma é: {resultado}");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Pressione Enter para Voltar ao Menu");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Digite um Numero: ");
            float valor1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite outro Numero: ");
            float valor2 = Convert.ToSingle(Console.ReadLine());

            float resultado = valor1 * valor2;
            Console.WriteLine($"O resultado da soma é: {resultado}");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Pressione Enter para Voltar ao Menu");
            Console.ReadKey();
            Menu();
        }

    }
}


