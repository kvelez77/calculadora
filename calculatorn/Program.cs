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
                Console.Write($"Ingresa el número {i}: ");
                string input = Console.ReadLine();

                // Validar que solo se ingresen números
                if (!int.TryParse(input, out int num))
                {
                    Console.WriteLine("Error: debes ingresar un número.");
                    i--;
                    continue;
                }

                // Guardar los números ingresados en las variables correspondientes
                if (i == 1)
                {
                    num1 = num;
                }
                else
                {
                    num2 = num;
                }
            }


        }
    }
}
