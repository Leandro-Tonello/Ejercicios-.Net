using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using HtmlAgilityPack;
using ScrapySharp.Extensions;

namespace _03_ApuntarURL

{
    public class GestionadorDeURL
    {
        public void CrearTexto(string nombre, string directorioDePC)
        {
            
            String fileFinal = System.IO.Path.Combine(directorioDePC, nombre+".txt");
            System.IO.FileStream fs = System.IO.File.Create(fileFinal);
            fs.Close();
        }

        public void EscribirWeb(string url, string directory, string nombreDelArchivo )
        {
            StreamWriter sw = new StreamWriter(directory + "/" + nombreDelArchivo +".txt");
            HtmlWeb web = new HtmlWeb();
            HtmlDocument html = web.Load(url);
            var nodes = html.DocumentNode.CssSelect("body").Select(x => x.InnerText);
            nodes.ToList().ForEach(e =>
            {
                sw.WriteLine(e);
            });
        }
    }
}