using Membot.Esp.Bot.Common.Enums;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Membot.Esp.Bot.Model.Reddit.DTO
{
    public class RedditSearchCommentRequest
    {
        [JsonProperty("article")]
        public string Article { get; set; }
        [JsonProperty("comment")]
        public string? Comment { get; set; }
        [JsonProperty("context")]
        public int Context { get; set; }
        [JsonProperty("depth")]
        public int? Depth { get; set; }
        [JsonProperty("limit")]
        public int? Limit { get; set; }
        [JsonProperty("showedits")]
        public bool ShowEdits { get; set; }
        [JsonProperty("showmedia")]
        public bool ShowMedia { get; set; }
        [JsonProperty("showmore")]
        public bool ShowMore { get; set; }
        [JsonProperty("showtitle")]
        public bool ShowTitle { get; set; }
        [JsonProperty("sort")]
        public RedditCommentSortEnum Sort { get; set; }
        [JsonProperty("theme")]
        public RedditThemeEnum Theme { get; set; }
        [JsonProperty("threaded")]
        public bool Threaded { get; set; }
        [JsonProperty("truncate")]
        public int Truncate { get; set; }
    }
}
