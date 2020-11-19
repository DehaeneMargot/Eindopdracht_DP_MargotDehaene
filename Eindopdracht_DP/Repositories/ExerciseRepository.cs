using Eindopdracht_DP.Models.Exercise;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Internals;

namespace Eindopdracht_DP.Repositories
{
    public static class ExerciseRepository
    {
        public const string _BASEAPI = "https://wger.de/api/v2";

        public async static Task<AllExercises> GetAllExercisesAsync()
        {
            try
            {
                //call api
                string url = $"{_BASEAPI}/exerciseinfo/?format=json";
                using (HttpClient client = GetClient())
                {
                    string json = await client.GetStringAsync(url);
                    AllExercises allExercises = JsonConvert.DeserializeObject<AllExercises>(json);
                    return allExercises;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        private static HttpClient GetClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            return client;
        }
    }
}
