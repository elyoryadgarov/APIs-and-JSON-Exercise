using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    
    internal class RonVSKanyeAPI
    {
        public string Quote(string URL)
        {
            var client = new HttpClient();
            var ronResponse = client.GetStringAsync(URL).Result;
            var ronQuote = JsonArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Replace('{',' ').Replace('}',' ').Replace("\"quote\":","").Trim();
            return ronQuote;
        }
    }
}
