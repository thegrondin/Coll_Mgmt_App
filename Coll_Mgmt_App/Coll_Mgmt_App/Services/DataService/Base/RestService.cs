using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Coll_Mgmt_App.Services.DataService.Base
{
    public class RestService : IRestService
    {
        HttpClient _client;
        public RestService(HttpClient client)
        {
            _client = client;
            _client.MaxResponseContentBufferSize = 256000;
        }
        public async Task<bool> AddAsync<T>(Uri uri, T item)
        {
            var json = JsonConvert.SerializeObject(item);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = null;
            response = await _client.PostAsync(uri, content);

            if (!response.IsSuccessStatusCode)
                return false;

            return true;
        }

        public async Task<bool> DeleteAsync<T>(Uri uri, string id)
        {

            var response = await _client.DeleteAsync(uri);
            if (response.IsSuccessStatusCode)
                return true;

            return false;

        }

        async Task<T> IRestService.RefreshAsync<T>(Uri uri)
        {
            var response = await _client.GetAsync(uri);
            dynamic content = new JObject();
            if (response.IsSuccessStatusCode)
            {
                content = await response.Content.ReadAsStringAsync(); 
            }
            return JsonConvert.DeserializeObject<T>(content);
        }
    }
}
