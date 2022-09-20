using InsertRekrutacja.Models;
using Newtonsoft.Json;

namespace InsertRekrutacja.Services
{
    public class APIClient<T>
    {
        private readonly string _url;
        public APIClient(string url)
        {
            _url = url;
        }

        public IEnumerable<T> FetchList()
        {
            T[] data = { };
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(_url);
                HttpResponseMessage httpResponse = client.GetAsync(_url).Result;
                string response = httpResponse.Content.ReadAsStringAsync().Result;
                data = JsonConvert.DeserializeObject<T[]>(response);
            };
            
            return data;
        }
    }
}
