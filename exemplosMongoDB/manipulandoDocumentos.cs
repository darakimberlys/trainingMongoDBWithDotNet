using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace exemplosMongoDB
{
    class manipulandoDocumentos
    {
        static void Main(string[] args)
        {
            Task T = MainASync(args);
            Console.WriteLine("Pressione ENTER");
            Console.ReadLine();

        }
        static async Task MainASync(string[] args)
        {
            //{
            //    "Titulo":"Guerra dos Tronos",
            //    "Autor":"George R R Martin"',
            //    "Ano":1999,
            //    "Paginas":856,
            //    "Assunto":[
            //    "Fantasia",
            //    "Ação"
            //            ]
            //}

            var doc = new BsonDocument
            {
                {"Titulo", "Guerra dos Tronos"}
            };
            doc.Add("Autor", "George R R Martin");
            doc.Add("Ano", 1999);
            doc.Add("Paginas", 856);

            var assuntoArray = new BsonArray();
            assuntoArray.Add("Fantasia");
            assuntoArray.Add("Ação");

            doc.Add("Assunto", assuntoArray);
                       
           Console.WriteLine(doc);
            //await Task.Delay(10000);
            //Console.WriteLine("Esperei 10 segundos ...");
        }
    }
}
