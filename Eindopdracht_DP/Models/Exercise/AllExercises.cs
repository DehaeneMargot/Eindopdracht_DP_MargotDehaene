using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eindopdracht_DP.Models.Exercise
{
    public class AllExercises
    {
        [JsonProperty(PropertyName = "results")]
        public List<Exercise> Exercises { get; set; }
    }
}
