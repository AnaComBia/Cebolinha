﻿using System;

namespace Cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Escreva algo e eu vou demonstrar como o cebolinha falaria: ");
        
            String usuariofalar = Console.ReadLine();
            String usuariofalal = usuariofalar
            .Replace("r", "l")
            .Replace("R", "L");


            Console.Write("\njeito do cebolinha: ");
            Console.Write(usuariofalal);
            Console.WriteLine();
        }
    }
}
