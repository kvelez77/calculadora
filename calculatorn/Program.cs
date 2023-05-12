using System;

class Calculator
{
    static void Main()
    {
        int cho = 0;
        int num1 = 0;
        int num2 = 0;
        int result = 0;
        bool exit = false;

        Console.WriteLine("CALCULADORA");

        do
        {
            
            Console.Write("¿Cuántos números deseas ingresar?:");
            int count = int.Parse(Console.ReadLine());

            
            for (int i = 1; i <= count; i++)
            {
                Console.Write($"Ingresa el número {i}: ");
                string input = Console.ReadLine();

                
                if (!int.TryParse(input, out int num))
                {
                    Console.WriteLine("Error: debes ingresar un número.");
                    i--;
                    continue;
                }

                
                if (i == 1)
                {
                    num1 = num;
                }
                else
                {
                    num2 = num;
                }
            }

            
            Console.WriteLine("Selecciona una operación:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Salir");
            Console.Write("Tu elección: ");
            cho = int.Parse(Console.ReadLine());

            
            switch (cho)
            {
                case 1:
                    result = num1 + num2;
                    Console.WriteLine($"El resultado de la suma es: {result}");
                    break;
                case 2:
                    result = num1 - num2;
                    Console.WriteLine($"El resultado de la resta es: {result}");
                    break;
                case 3:
                    result = num1 * num2;
                    Console.WriteLine($"El resultado de la multiplicación es: {result}");
                    break;
                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: no se puede dividir entre cero.");
                    }
                    else
                    {
                        result = num1 / num2;
                        Console.WriteLine($"El resultado de la división es: {result}");
                    }
                    break;
                case 5:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Error: elección inválida.");
                    break;
            }
        } while (!exit);
    }
}
