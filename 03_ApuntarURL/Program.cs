using HtmlAgilityPack;
using ScrapySharp.Extensions;
using System;
using System.IO;
using System.Linq;


namespace _03_ApuntarURL
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            
            string url;
            string directory;
            string nombreDeArchivo;

            if (args.Length > 0)
            {
                url = args[0];
            }
            else
            {
                Console.WriteLine("Ingrese la direccion Web");
                url = Console.ReadLine();
            }

            if (args.Length >= 1 )
            {
                directory = args[1];
            }
            else
            {
                Console.WriteLine("Ingrese el directorio donde guardar");
                directory = Console.ReadLine();
            }

          
            if (args.Length > 1)
            {
                nombreDeArchivo = args[2];
            }
            else
            {
                Console.WriteLine("Ingrese el nombre del archivo");
                nombreDeArchivo = Console.ReadLine();
            }

            GestionadorDeURL gestionador = new GestionadorDeURL(args[0], args[1], args[2]);
            //Por que ahora me pide que le declare variables y en ejercicios anteriores no
            gestionador.CrearTexto(args[2], args[1]);
        }
    }
}