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
            Console.WriteLine("Ingrese la direccion Web");
            var url = Console.ReadLine();  
            Console.WriteLine("Ingrese el directorio donde guardar");
            var directory = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del archivo");
            var nombreDelArchivo = Console.ReadLine();
            
            gestionador.CrearTexto(nombreDelArchivo,directory);
            gestionador.EscribirWeb(url,directory,nombreDelArchivo);
       
        }
    }
}