using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace APIsAndJSON
{
    internal  class RonVSKanyeAPI
    {
        public static void Ron()
        {
            HttpClient client = new HttpClient();

            string ronEndpoint = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            string ronResponse = client.GetStringAsync(ronEndpoint).Result;

            JArray ronObject = JArray.Parse(ronResponse);
            
            Console.WriteLine($"Ron: {ronObject[0]}");
        }
        public static void Kanye()
        {
            var client = new HttpClient();

            var kanyeEndpoint = "https://api.kanye.rest/";

            var kanyeResponse = client.GetStringAsync(kanyeEndpoint).Result;

            var kanyeObject = JObject.Parse(kanyeResponse);

            Console.WriteLine($"Kanye: {kanyeObject["quote"]}");
        }

        public static void RonAndKanye()
        {
            for (int i = 0; i < 5; i++)
            {
                Ron();
                Kanye();
                Console.WriteLine();
            }
        }
    }
}
