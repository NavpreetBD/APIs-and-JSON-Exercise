using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    internal class RonVSKanyeAPI
    {
        public static void Ron()  //static way is easier here so don't have to create instances
        {
            HttpClient client = new HttpClient();

            string ronEndPoint = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            string ronResponse = client.GetStringAsync(ronEndPoint).Result;

            JArray ronObject = JArray.Parse(ronResponse);

           // Console.WriteLine(ronObject);
            //Console.WriteLine(ronObject[0]); // to get just the quote without brackets

            //if want to consider the name :quote,,use string interplation
            Console.WriteLine($"Ron: {ronObject[0]}");
        }

        public static void Kanye()
        {
            HttpClient client = new HttpClient();

            string kanyeEndPoint = "https://api.kanye.rest/";

            string kanyeResponse = client.GetStringAsync(kanyeEndPoint).Result;

            JObject kanyeObject = JObject.Parse(kanyeResponse);

            //Console.WriteLine(kanyeObject);

            //Console.WriteLine(kanyeObject["quote"]); //to get just a quote

            Console.WriteLine($"Kanye: {kanyeObject["quote"]}");



        }

        //to make a coversation between kanye and ron- make a another method 
        public static void Convo()
        {
            for (int i = 0; i < 5; i++)
            {
                RonVSKanyeAPI.Ron(); // we can also call this by Ron(), because its within the class
                RonVSKanyeAPI.Kanye();
            }
        }


    }
}
