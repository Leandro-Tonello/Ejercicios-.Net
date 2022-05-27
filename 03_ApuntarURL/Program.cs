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

            GestionadorDeURL gestionador = new GestionadorDeURL();
            string url;
            if (args.Length > 0)
            {
                url = args[0];
            }
            else
            {
                Console.WriteLine("Ingrese la direccion Web");
                url = Console.ReadLine();
            }

            //TODO: que la url ingrese por argumento de linea de comandos (args)
            Console.WriteLine("Ingrese el directorio donde guardar");
            var directory = Console.ReadLine();

            //TODO: que la url ingrese por argumento de linea de comandos (args)
            Console.WriteLine("Ingrese el nombre del archivo");
            var nombreDelArchivo = Console.ReadLine();
            
            gestionador.CrearTexto(nombreDelArchivo,directory);
            gestionador.EscribirWeb(url,directory,nombreDelArchivo);
       
        }
    }
}