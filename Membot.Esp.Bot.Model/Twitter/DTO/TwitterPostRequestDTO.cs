using Membot.Esp.Bot.Model.Twitter.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Membot.Esp.Bot.Model.Twitter.DTO
{
    public class TwitterPostRequestDTO
    {
        [JsonProperty("media")]
        public TwitterMediaModel Media { get; set; }

    }
}
