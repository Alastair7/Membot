using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Membot.Esp.Bot.Model.Twitter.Models
{
    public class TwitterMediaModel
    {
        [JsonProperty("media_key")]
        public string MediaKey { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("duration_ms")]
        public int Duration { get; set; }
        [JsonProperty("height")]
        public int Height { get; set; }
        [JsonProperty("preview_image_url")]
        public string PreviewImageUrl { get; set; }
        [JsonProperty("width")]
        public int Width { get; set; }
        [JsonProperty("alt_text")]
        public string AltText { get; set; }

    }
}
