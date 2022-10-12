using System;
using Newtonsoft.Json.Linq;

namespace KanyeAndRonAPI
{
    public class RandomQuote
    {
        public static void KanyeQuote()
        {
            // Making a New Client Object //
            // Provies a base class for sending HTTP Requests and receiving HTTP Responses //
            var client = new HttpClient();

            // String that holds the URL //
            var kanyeURL = "https://api.kanye.rest/";
            // Put inside of the Get String Async Method // 
            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
            // Now we need to Parse the Response //
            // Need to add a nuget package Newtonsoft. Allows us to work with JSON //
            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
            Console.WriteLine("\n****************************************************************");
            Console.WriteLine($"> Kanye: {kanyeQuote}");
            Console.WriteLine("****************************************************************\n");

        }

        public static void RonQuote()
        {
            var client = new HttpClient();

            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronResponse = client.GetStringAsync(ronURL).Result;

            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
            Console.WriteLine("****************************************************************");
            Console.WriteLine($"> Ron: {ronQuote}");
            Console.WriteLine("****************************************************************");
            Console.Write("\n> Press Enter To Continue\n");
            Console.ReadKey();
        }
    }
}

