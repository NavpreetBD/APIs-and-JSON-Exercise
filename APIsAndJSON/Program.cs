using Newtonsoft.Json.Linq;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            //RonVSKanyeAPI.Ron();

            // RonVSKanyeAPI.Kanye();
            
            // only calling this method, because this call other methods too within itself
            // RonVSKanyeAPI.Convo();

            OpenWeatherMapAPI.GetWeatherByCity();



            /////// FIRST LECTURE MATERIAL TO GO OVER ///////
          //  HttpClient client = new HttpClient();  //client
            // this is instance for http client to send request to the choosen endpoint or URL

         //   string ronEndPoint = "https://ron-swanson-quotes.herokuapp.com/v2/quotes"; //endpoint as a string

         //   string ronResponse = client.GetStringAsync(ronEndPoint).Result; // using client to send a request to given endpoint
            //async thing allows to send multiple requests without locking up the program
            //.Result means to get response in string

         //   JArray ronObject = JArray.Parse(ronResponse); //parsing into array--return type JArray

         //   Console.WriteLine(ronResponse);

            //don't want brackets, just the quotes --use indexing
         //   Console.WriteLine(ronObject[0]);



            // HttpClient client = new HttpClient(); // client 

         //   string kanyeEndPoint = "https://api.kanye.rest/"; //endpoint

         //   string kanyeResponse = client.GetStringAsync(kanyeEndPoint).Result; //response

          //  JObject kanyeObject = JObject.Parse(kanyeResponse); // parsing the response/the given string into J object

         //   Console.WriteLine(kanyeObject);



          
        }
    }
}
