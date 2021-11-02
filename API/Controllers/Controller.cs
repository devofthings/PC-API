using API;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace WebUebung
{
    public class Controller
    {
        private string _value;
        public string Value { get => _value; set => _value = value; }
        public Controller()
        {
            Value = "";
        }
        public List <Computer> UsePCApi(string type, int id, string para = "", string para2 = "", int para3 = 0, string para4 = "", string para5 = "", int para6 = 0)
        {
            HttpClient client = new HttpClient();
            string url = "http://localhost:1337/api/computer";
            Task<HttpResponseMessage> response = client.GetAsync(url);

            switch (type)
            {
                case "getPC":
                    url = $"{url}";
                    response = client.GetAsync(url);
                    break;
                case "postPC":
                    url = $"{url}";
                    response = client.PostAsJsonAsync(url, new Computer(id, "Intel Core 2 Duo", "NVIDA GT700M", 2, "AS ROCK CRAP", "Kohlekraftwerk Sölden", 40));
                    break;
                case "putPC":
                    url = $"{url}/{id}?para={para}&para2={para2}&para3={para3}&para4={para4}&para5={para5}&para6={para6}";
                    string json = JsonConvert.SerializeObject(Global.PCs);
                    response = client.PutAsJsonAsync(url, json);
                    break;
                case "delPC":
                    url = $"{url}/{id}";
                    response = client.DeleteAsync(url);
                    break;
            }

            try
            {
                response.Wait();
            }
            catch (Exception e)
            {
                //Fehlermeldung
            }

            HttpResponseMessage result = response.Result;
            Task<string> content = result.Content.ReadAsStringAsync();

            try
            {
                content.Wait();
            }
            catch (Exception e)
            {
                //Fehlermeldung
            }

            string receive = content.Result;
            return JsonConvert.DeserializeObject<List <Computer>>(receive);
        }
    }
}