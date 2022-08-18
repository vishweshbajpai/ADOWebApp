using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ADOWebApplication.ADORepositories
{
    public class HttpConnectRepo <T>
    {
        HttpClient _client;
        public HttpConnectRepo()
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://localhost:44385/");
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public async Task<List<T>> GetRequest(string path, int id = -1)
        {
            List<T> list = new List<T>();
            HttpResponseMessage response;
            if (id != -1)
                response = await _client.GetAsync(path + id);
            else
                response = await _client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                //var product = response.Content.ReadAsStringAsync().Result;
                if (id != -1)
                {
                    var product = await response.Content.ReadAsAsync<T>();
                    list.Add(product);
                }
                else
                {
                    var product = await response.Content.ReadAsStringAsync();
                    list = JsonConvert.DeserializeObject<List<T>>(product);
                }
            }
            return list;
        }
        public async Task<bool> PostRequest(string path, T inputObj)
        {
            HttpResponseMessage response = await _client.PostAsJsonAsync(path, inputObj);
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }
        public async Task<bool> PutRequest(string path, int id, T inputObj)
        {
            HttpResponseMessage response = await _client.PutAsJsonAsync(path + id, inputObj);
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }
        public async Task<bool> DeleteRequest(string path,int id)
        {
            HttpResponseMessage response = await _client.DeleteAsync(path + id);
            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }
    }
}