using System;
using System.Threading;

namespace TareaProgra1
{
    class Program
    {
          public static string Mid(string parametro, int startindex, int Length)
        {
            string result = parametro.Substring(startindex, Length);
            return result;
        }
        static void Main(string[] args)
        {
            string NOMBRE;
            string LETRA_CARACTERES;
            int LETRA_DESPLAZAR = 0;
            int FUNCION_CONTEO = 0;
            int LONGITUD = 0;
            int POSICIONES = 0;
            Console.Write("Ingrese su nombre: ");
            NOMBRE = Console.ReadLine();
            Console.SetCursorPosition(1, 12);
            Console.Write(NOMBRE);
            LONGITUD = NOMBRE.Length;
            POSICIONES = 70;
            NOMBRE = NOMBRE.ToUpper();
            for (FUNCION_CONTEO = NOMBRE.Length; FUNCION_CONTEO >= 1; FUNCION_CONTEO--)
            {
                LETRA_CARACTERES = Mid(NOMBRE, FUNCION_CONTEO - 1, 1);
                for (LETRA_DESPLAZAR = LONGITUD; LETRA_DESPLAZAR <= POSICIONES; LETRA_DESPLAZAR++)
                {
                    Console.SetCursorPosition(LETRA_DESPLAZAR, 12);
                    Console.Write(" " + LETRA_CARACTERES);
                    Thread.Sleep(50);
                }
                POSICIONES = POSICIONES - 1;
                LONGITUD = LONGITUD - 1;
            }
        }
    }
}

