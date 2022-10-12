using Newtonsoft.Json.Linq;
using static System.Net.WebRequestMethods;
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

Console.WriteLine($"Kanye: {kanyeQuote}");
Console.ReadKey();

