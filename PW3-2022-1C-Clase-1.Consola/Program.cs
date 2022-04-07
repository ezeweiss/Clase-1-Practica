using PW3_2022_1C_Clase_1.Entidades;
using System;

namespace PW3_2022_1C_Clase_1.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int continuar;          
            int opcion;

        do
         {
            Console.WriteLine("Bienvenido a la calculadora!");
            Console.WriteLine("Selección la operación que desee calcular: \n 1.Suma \n 2.Resta \n 3.Multiplicación \n 4.División");
            int.TryParse(Console.ReadLine(), out opcion);

            Calcular(opcion);

            Console.WriteLine("¿Desea realizar otro Calculo?");
            Console.WriteLine("1 - Si");
            Console.WriteLine("2 - No");
            int.TryParse(Console.ReadLine(),out continuar);

            if (continuar == 1)
            {
               Console.Clear();
            }

        } while (continuar == 1);

            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();
        }

        public static void Calcular(int opcion)
        {
            Console.WriteLine("Ingrese los numeros:");

            Console.WriteLine("Num 1: ");
            string num1 = Console.ReadLine();

            Console.WriteLine("Num 2: ");
            string num2 = Console.ReadLine();

            int int1 = Int32.Parse(num1);
            int int2 = Int32.Parse(num2);
 
            switch (opcion)
            {
                case 1:
                    Console.WriteLine($"El resultado es: {Calculadora.Sumar(num1, num2)}");
                    break;
                case 2:
                    Console.WriteLine($"El resultado es: {Calculadora.Restar(num1, num2)}");
                    break;
                case 3:
                    Console.WriteLine($"El resultado es: {Calculadora.Multiplicar(num1, num2)}");
                    break;
                case 4:
                    Console.WriteLine($"El resultado es: {Calculadora.Dividir(num1, num2)}");
                    break;
                default:
                    Console.WriteLine("Opción Inválida");
                    break;
            }
        }
    }
}
