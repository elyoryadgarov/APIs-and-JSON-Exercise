using System.Text.Json.Nodes;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            string ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            for (int i = 0; i < 5; i++)
            {
                var ronResponse = client.GetStringAsync(ronURL).Result;
                var ronQuote = JsonArray.Parse(ronResponse).ToString().Replace('[',' ').Replace(']',' ').Trim();
                Console.WriteLine($"Ron: {ronQuote}");   
            }
            
            string kanyeURL = "https://api.kanye.rest";

            for (int i = 0; i < 5; i++)
            {
                var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
                var kanyeQuote = JsonArray.Parse(kanyeResponse).ToString().Replace('{',' ').Replace('}',' ').Replace("\"quote\":","").Trim();
                
                Console.WriteLine($"Kanye: {kanyeQuote}"); 
            }
            
        }
    }
}
