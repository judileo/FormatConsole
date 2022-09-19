using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FormatConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int Fila = 0;
            int Columna = 0;
            int F = 0;
            int C = 0;
            string linea;
            Random rnd = new Random();


            Console.Write("FILAS DE LA MATRIZ:");
            linea = Console.ReadLine();
            Fila = int.Parse(linea);

            Console.Write("COLUMNAS DE LA MATRIZ:");
            linea = Console.ReadLine();
            Columna = int.Parse(linea);


            int[,] MAT = new int[Fila + 1, Columna + 1];

            for (F = 1; F <= Fila; F++)
            {
                for (C = 1; C <= Columna; C++)
                {
                    MAT[F, C] = rnd.Next(0, 99);
                }
            }

            for (F = 1; F <= Fila; F++)
            {
                for (C = 1; C <= Columna; C++)
                {
                    Console.SetCursorPosition(C * 4, F + 1);
                    Console.Write(MAT[F, C]);
                }
            }
            Console.WriteLine();
            //Console.Write("Pulse una Tecla:");
            //Console.ReadLine();
        }
    }
}
