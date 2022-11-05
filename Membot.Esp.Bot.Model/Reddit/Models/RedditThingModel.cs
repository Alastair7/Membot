using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Membot.Esp.Bot.Model.Reddit.Models
{
    public class RedditThingModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("kind")]
        public string Kind { get; set; }
        [JsonProperty("data")]
        public object Data { get; set; }
    }
}
