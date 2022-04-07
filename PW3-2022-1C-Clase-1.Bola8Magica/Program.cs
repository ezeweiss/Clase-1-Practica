using PW3_2022_1C_Clase_1.Entidades;
using System;


namespace PW3_2022_1C_Clase_1.Bola8Magica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int continuar;
            string pregunta;

            do { 
            Console.WriteLine("Bienvenidos a la Bola 8 mágica!");

            Console.WriteLine("Ingrese la pregunta a realizar: ");
            pregunta = Console.ReadLine();

            string respuesta = Bola_8_Magica.Preguntar(pregunta);
            Console.WriteLine(respuesta);

            Console.WriteLine("¿Desea realizar otra pregunta?");
            Console.WriteLine("1 - Si");
            Console.WriteLine("2 - No");
            int.TryParse(Console.ReadLine(), out continuar);

            if (continuar == 1)
            {
                Console.Clear();
            }
            } while (continuar == 1);

            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();
        }
    }
}

