using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Membot.Esp.Bot.Model.Twitter.Models
{
    public class TwitterTweetModel
    {
        [JsonProperty("id")]
        public string Id { get; set; } = string.Empty;
        [JsonProperty("text")]
        public string Text { get; set; } = string.Empty;
        [JsonProperty("attachments")]
        public TwitterMediaModel Attachments { get; set; }
        [JsonProperty("author_id")]
        public string AuthorId { get; set; } = string.Empty;
        [JsonProperty("in_reply_to_user_id")]
        public string InReplyToUserId { get; set; } = string.Empty;
        [JsonProperty("lang")]
        public string Language { get; set; } = "es";
        [JsonProperty("possibly_sensitive")]
        public bool Sensitive { get; set; }
        [JsonProperty("source")]
        public string Source { get; set; } = "Xenocide";
    }
}
