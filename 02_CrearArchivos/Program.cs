using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _02_CrearArchivos
{
    class Program
    {
        static void Main(string[] args)
        {
           
            {
                var argumentos = new List<string>();
                argumentos.AddRange(args);
                var randomDirectory = new RandomDirectory();
                randomDirectory.CreateFile(argumentos[0], argumentos[1]);
            }
        }

    }
 }

