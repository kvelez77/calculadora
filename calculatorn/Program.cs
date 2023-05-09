using System;

namespace calculatorn
{
    class Program
    {
        static void Main(string[] args)
        {
            int cho = 0;
            int num1 = 0;
            int num2 = 0;
            int result = 0;
            
            Console.WriteLine("Bienvenido a la calculadora");
            Console.WriteLine("Ingresa la cantidad de numeros que deseas calcular");
            int cannumero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= cannumero; i++)
            {
                Console.Write("Ingresa el numero {i}: ");
                string input = Console.ReadLine();
            }

        }
    }
}
