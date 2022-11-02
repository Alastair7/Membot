using Membot.Esp.Bot.Model.Reddit.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Membot.Esp.Bot.Model.Reddit.DTO
{
    public class RedditSearchRequestDTO
    {
        [JsonProperty("after")]
        public RedditThingModel After { get; set; }
        [JsonProperty("before")]
        public RedditThingModel Before { get; set; }
        [JsonProperty("count")]
        public int Count { get; set; } = 0;
        [JsonProperty("include_facets")]
        public bool Include_Facets { get; set; }
        [JsonProperty("limit")]
        public int Limit { get; set; } = 25;
        [JsonProperty("q")]
        public string q { get; set; }
        [JsonProperty("restrict_sr")]

    }
}
