using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class QuoteGenerator
    {
        public QuoteGenerator(HttpClient client)
        {
        }

        public static void KanyeQuote()
        {
            var client = new HttpClient();

            string kanyeUrl = "https://api.kanye.rest";

            var kanyeResponse = client.GetStringAsync(kanyeUrl).Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            Console.WriteLine($"----------------------");
            Console.WriteLine($"Kanye: '{kanyeQuote}'");
            Console.WriteLine($"----------------------");
            Console.WriteLine();
        }

        public static void RonQuote()
        {
            var client = new HttpClient();

            string ronUrl = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronResponse = client.GetStringAsync(ronUrl).Result;

            var ronQuote = JArray.Parse(ronResponse);

            Console.WriteLine($"----------------------");
            Console.WriteLine($"Ron: '{ronQuote[0]}'");
            Console.WriteLine($"----------------------");
            Console.WriteLine();
        }
    }
}
