using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Membot.Esp.Bot.Model.Bot.DTO
{
    public class TwitterDeleteResponseDTO
    {
        [JsonProperty("deleted")]
        public bool Deleted { get; set; }

    }
}
