using System;
using System.Threading;

namespace TareaProgra2
{
    class Program
    {
        public static void dibuja(int Cantidad)
        {
            int FILAS = 22;
            int COLUMNAS = 77;
            int ESPACIO1 = 2;
            int ESPACIO2 = 2;
            int F, C, A;

            for (A = 1; A <= Cantidad; A++)
            {
                for (F = ESPACIO2; F <= COLUMNAS; F++)
                {
                    Console.SetCursorPosition(F, FILAS); Console.Write("?");
                    Console.SetCursorPosition(F, ESPACIO1); Console.Write("?");
                }
                for (C = ESPACIO2; C <= FILAS; C++)
                {
                    Console.SetCursorPosition(ESPACIO2, C); Console.Write("X");
                    Console.SetCursorPosition(COLUMNAS, C); Console.Write("X");
                }
                ESPACIO1 = ESPACIO1 + 1;
                FILAS = FILAS - 1;
                ESPACIO2 = ESPACIO2 + 1;
                COLUMNAS = COLUMNAS - 1;
            }
        }

        static void Main(string[] args)
        {
            for (int TAMAÑO = 1; TAMAÑO < 9; TAMAÑO++)
            {
                dibuja(TAMAÑO);
                Thread.Sleep(1000);
            }

        }



    }
}
