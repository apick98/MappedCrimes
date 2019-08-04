using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace map3
{
    public class PoliceProcessor
    {
        public static async Task<List<PoliceModel>> LoadCrimesByLatitudeLongitude(double latitude, double longitude)
        {
            string url = $"https://data.police.uk/api/crimes-street/all-crime?lat={latitude}&lng={longitude}";
            using (HttpResponseMessage response = await APIHelper.APIClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    List<PoliceModel> crime = await response.Content.ReadAsAsync<List<PoliceModel>>();
                    return crime;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
