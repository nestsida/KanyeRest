using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace KanyeREST
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var client = new HttpClient();
            var kanyeURL = "https://api.kanye.rest";
            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();

            
            Console.WriteLine("Who am I?");
            Console.WriteLine($"Kanye: {kanyeQuote}");
            Console.WriteLine("I will see you in heaven");

           
            
            
        }
        public static void RonQuote()
        {
            var client = new HttpClient();
            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var ronResponse = client.GetStringAsync(ronURL).Result;
            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();

            Console.WriteLine("you tell me.");
            Console.WriteLine($"Ron: {ronQuote}");
            Console.WriteLine("oh please");

        }

    }
}
