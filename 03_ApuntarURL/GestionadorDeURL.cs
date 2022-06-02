using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using RestSharp;
using AngleSharp;
using AngleSharp.Dom;
using AngleSharp.Html.Parser;
using System.Threading.Tasks;

namespace _03_ApuntarURL

{
    public class GestionadorDeURL
    {
        public void CrearTexto(string nombre, string directorioDePC)
        {
            var fileFinal = System.IO.Path.Combine(directorioDePC, nombre + ".txt");
            using (var fs = System.IO.File.Create(fileFinal))
            {
                fs.Close();
            }
        }

        public void EscribirWeb(string url, string directory, string nombreDelArchivo)
        {
            // No se si esta es la forma correcta de declarar una web en RestSharp 
            var client = new RestClient(directory);
            var request = new RestRequest(directory, Method.Post);
                // Como hago para pasar el contenido del client (el html) al var document de abajo
                var Html =  ????? ;
                //Grabo el html de la peticion en una lista
            List<string> hrefTags = new List<string>();
            var parser = new HtmlParser();
            //No puedo continuar con este ejercicio ya que en ningun momento recibo el HTML crudo
            var document = parser.ParseDocument(Html);

            foreach (IElement element in document.QuerySelectorAll("a"))
            {
                hrefTags.Add(element.GetAttribute("href"));
            }
            

        }

   



    }
}