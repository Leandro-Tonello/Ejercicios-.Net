using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _02_CrearArchivos
{
    class RandomDirectory
    {
       
        public void CreateFile(string myDirectory, string cantidad)
        {
            int x = 0;
            x = int.Parse(cantidad);
            x = Convert.ToInt32(cantidad);

            if (!Directory.Exists(myDirectory))
            {
                Console.WriteLine("Creando el directorio: {0}", myDirectory);
                DirectoryInfo di = Directory.CreateDirectory(myDirectory);
            }
            else
            {
                Console.WriteLine("El directorio ya existe");
            }


            for (int i=0; i < x; i++)
            {

                string fileName = System.IO.Path.GetRandomFileName();
                String fileFinal = System.IO.Path.Combine(myDirectory, fileName);
                System.IO.FileStream fs = System.IO.File.Create(fileFinal);

            }
        }
    }
}
