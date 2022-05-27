using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaDeTrabajo
{
    class DirectoryManager
    {
        public void ListDirectory(string myDirectory)
        {
            string[] listFiles;

            if (Directory.Exists(myDirectory))
            {
                listFiles = Directory.GetFiles(myDirectory);
                DirectoryInfo dir = new DirectoryInfo(myDirectory);
                FileInfo[] infoFicheros = dir.GetFiles();
                foreach (FileInfo infoUnFich in infoFicheros)
                {
                    Console.WriteLine("{0}, de tamaño {1}, creado {2}",
                    infoUnFich.Name,
                    infoUnFich.Length,
                    infoUnFich.CreationTime);
                }
            }
            else
            {
                Console.WriteLine("El directorio no existe");
            }

        }


        public void CreateDirectory(string a)
        {
            string myDirectory = a;
            if (!Directory.Exists(myDirectory))
            {
                Console.WriteLine("Creando el directorio: {0}", myDirectory);
                DirectoryInfo di = Directory.CreateDirectory(myDirectory);
            }
            else
            {
                Console.WriteLine("El directorio ya existe");
            }

        }

        public void CreateFileText(string myDirectory, string texto)
        {

            if (!File.Exists(myDirectory))
            {
                using (StreamWriter mylogs = File.AppendText(myDirectory))

                {
                    mylogs.WriteLine(texto);
                    mylogs.Close();
                    Console.WriteLine("Se creo el archivo de texto");
                }
            }

            else
            {
                Console.WriteLine("El archivo de texto ya existe");
            }
        }

        public void UpdateFileText(string myDirectory, string texto)
        {
            if (!File.Exists(myDirectory))
            {
                Console.WriteLine("El archivo de texto no existe");
            }
            else
            {
                using (StreamWriter file = new StreamWriter(myDirectory, true))
                {
                    file.WriteLine(texto);
                    file.Close();
                }
            }

        }

    }

}
