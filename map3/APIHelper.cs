using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace map3
{
    public static class APIHelper
    {
        //make it static so it only opens once
        public static HttpClient APIClient { get; set; } = new HttpClient();
        public static void InitialiseClient()
        {
            APIClient = new HttpClient();
            //APIClient.BaseAddress = new Uri("http://xk");
            APIClient.DefaultRequestHeaders.Accept.Clear();
            APIClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
