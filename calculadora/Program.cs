using System;

namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-Vindo a Calculadora em C#\n");
            
            Console.WriteLine("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine().ToString());   

            Console.WriteLine("Digite o segundo número: ");
            int num2 = int.Parse(Console.ReadLine().ToString());

            Console.WriteLine("\nDigite a operação desejada");
            Console.WriteLine("1-SOMA");
            Console.WriteLine("2-SUBTRAÇÃO");
            Console.WriteLine("3-MULTIPLICAÇÃO");
            Console.WriteLine("4-DIVISÃO\n");
            int operacao = int.Parse(Console.ReadLine().ToString());
            double resultado = 0;
            
            switch (operacao)
            {
                case 1:
                    resultado = Soma(num1, num2);
                    break;
                case 2:
                    resultado = Subtracao(num1, num2);
                    break;
                case 3:
                    resultado = Multiplicacao(num1, num2);
                    break;
                case 4:
                    resultado = Divisao(num1, num2);
                    break;

                default:
                    break;
            }

            Console.WriteLine($"\nO resultado da operação foi: {resultado}");
            Console.ReadLine(); 
        }

        public static double Soma(int num1, int num2) => num1+num2;
        public static double Subtracao(int num1, int num2) => num1 - num2;
        public static double Multiplicacao(int num1, int num2) => num1 * num2;
        public static double Divisao(int num1, int num2) => num1 / num2;


    }
}
