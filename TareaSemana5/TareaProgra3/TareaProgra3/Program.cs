using System;

namespace TareaProgra3
{
    class Program
    {
        public static string generaLetra(int min, int max)
        {
            Random ran = new Random();
            string letraRespuestas = "";
            int NUM = Convert.ToInt32(ran.Next(97, 122));
            if ((NUM > min) & (NUM < max))
            {
                letraRespuestas = Convert.ToString((char)NUM);
            }
            return letraRespuestas;
        }
        static void Main(string[] args)
        {
            byte CANTIDAD, K;
            string linea;
            Console.Write("Longitud de Token: ");
            linea = Console.ReadLine();
            CANTIDAD = byte.Parse(linea);
            string letra = "";
            for (K = 1; K <= CANTIDAD; K++)
            {
                letra = letra + generaLetra(97, 122);
            }
            Console.WriteLine($"Token Generado= {letra}");
        }
}
}
