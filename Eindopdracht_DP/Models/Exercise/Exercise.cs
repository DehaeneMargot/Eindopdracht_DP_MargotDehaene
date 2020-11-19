using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eindopdracht_DP.Models.Exercise
{
    public class Exercise
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
