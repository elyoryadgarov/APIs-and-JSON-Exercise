using System.Text.Json.Nodes;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
        RonVSKanyeAPI api = new RonVSKanyeAPI();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ron: {api.Quote("https://ron-swanson-quotes.herokuapp.com/v2/quotes")}");
            }
            Console.WriteLine("\nNow Kanye's Turn\n");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Kanye: {api.Quote("https://api.kanye.rest")}");
            }
            
           
        }
    }
}
