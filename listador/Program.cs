using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace AreaDeTrabajo
{
   
    class Program
    {
        static void Main(string[] args)
        {
            var argumentos = new List<string>();
            argumentos.AddRange(args);
            var directoryManager = new DirectoryManager();
            directoryManager.ListDirectory(argumentos[0]); 
        }
    }
}   