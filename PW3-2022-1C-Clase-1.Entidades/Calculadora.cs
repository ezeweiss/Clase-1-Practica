using System;

namespace PW3_2022_1C_Clase_1.Entidades
{
    public static class Calculadora
    {
        public static int Sumar(string val1, string val2)
        {
            int int1 = Int32.Parse(val1);
            int int2 = Convert.ToInt32(val2);
            return int1 + int2;
        }

        public static int Restar(string val1, string val2)
        {
            int int1 = Int32.Parse(val1);
            int int2 = Convert.ToInt32(val2);
            return int1 - int2;
        }

        public static int Multiplicar(string val1, string val2)
        {
            int int1 = Int32.Parse(val1);
            int int2 = Convert.ToInt32(val2);
            return int1 * int2;
        }

        public static int Dividir(string val1, string val2)
        {
            int int1 = Int32.Parse(val1);
            int int2 = Convert.ToInt32(val2);

            if(int2 <= 0)
            {
                Console.WriteLine("No se puede dividir por 0");
            }
            return int1 / int2;
        }
    }
}
