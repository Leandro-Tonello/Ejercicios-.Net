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
            // Entonces hay que repasar el modelo de comunicación del protocolo HTTP, entender cuales son 
            // los elementos que intervienen en el mecanismo de comunicación y cuales son todas las opciones disponibles y para qué se usan.

            // - https://developer.mozilla.org/es/docs/Web/HTTP/Overview
            // - https://es.wikipedia.org/wiki/Protocolo_de_transferencia_de_hipertexto

            // despues que hayas leido esos documentos, hacemos una revisión y explicación del mecanismo de funcionamiento


            var client = new RestClient(directory);
            var request = new RestRequest(directory, Method.Post);

            // Como hago para pasar el contenido del client (el html) al var document de abajo
            // Para obtener el html, hay que ejecutar el request y esperar que el servidor http responda
            // En versiones anteriores de RestSharp esto se podía hacer de forma sincrónica (en realidad las comunicaciones son asíncronicas, pero lo resolvía internamente la librería y quien la usaba lograba la sensación de sincronismo. (Creo que tendrías que leer algo sobre esto para entender las diferencias entre asincronico y sincrónico, aunque es avanzado, y mucho mas vas a aprender viendo el código fuente, aunque es medio complejo)

            var Html = "";
            // El código fuente que perminte la ejecución asincrónica quedaría así ->
            var requestTask = client.ExecuteAsync(request);
            requestTask.ContinueWith(requestTaskFinished => {
                var result = requestTaskFinished.Result;

                var statusCode = result.StatusCode;
                var statusDescripcion = result.StatusDescription;
                var content = result.Content;

                Html = content;
            });

            requestTask.Wait();

    
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