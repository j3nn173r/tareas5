using System;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            public static string GeneraLetra()
            {
                Random ran = new Random();
                int NUMERO = Convert.ToInt32(ran.Next(90, 105));
                string respuesta = "no existe";



                if ((NUMERO > 91) & (NUMERO < 106))
                {
                    respuesta = Convert.ToString((char)NUMERO);

                }
                return respuesta;
            }


            static void Main(string[] args)
            {
                byte tamaño, s;

                string numeros;
                Console.WriteLine("Cuantos Numeros");
                numeros = Console.ReadLine();
                tamaño = byte.Parse(numeros);
                string Letras = " ";


                for (s = 1; s <= tamaño; s++)
                {
                    Letras = GeneraLetra();
                    Console.WriteLine($"el codigo {Letras}");

                }
            }
        }
    }








