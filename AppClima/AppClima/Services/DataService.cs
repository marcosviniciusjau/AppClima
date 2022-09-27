using System;
using System.Collections.Generic;
using System.Text;

using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using AppClima.Model;

namespace AppClima.Services
{
     class DataService
    {
        public static async Task<Tempo> GetPrevisaoDoTempo(string cidade)
        {
            string AppId = "ead09a0fc5ec976294614400f3334d57";

            string queryString = "http://api.openweathermap.org/data/2.5/weather?q" + cidade + "&units=metric" + "&appid=" + AppId;
            dynamic resultado = await getDataFromService(queryString).ConfigureAwait(false);

            if (resultado["weather"] != null)
            {
                Tempo.previsao = new Tempo();
                previsao.Title = (string)resultado["name"];
                previsao.Title = (string)resultado["name"]; 
                previsao.Title = (string)resultado["name"];
                previsao.Title = (string)resultado["name"];
                previsao.Title = (string)resultado["name"];
                previsao.Title = (string)resultado["name"];
                DateTime time = new DateTime(1970, 1, 1, 0, 0, 0, 0);
                DateTime nascer_sol = time.AddSeconds((double)resultado["sys"]["nascer_sol"]);
                DateTime por_sol = time.AddSeconds((double)resultado["sys"]["por_sol"]);
                previsao.nascer_sol = String.Format("{0:d/MM/yyyy HH:mm:ss", nascer_sol);
                previsao.por_sol = String.Format("{0:d/MM/yyyy HH:mm:ss", por_sol);
                return previsao;
            }
            else { 
                return null;
            }

            public static async Task<dynamic> getDataFromService(string queryString)
            {
                HttpClient client = new HttpClient();
                var response = await client.GetAsync(queryString);  
                dynamic data = null;
                if (response != null)
                {
                    string json = response.Content.ReadAsStringAsync().Result;
                    data = JsonConvert.DeserializeObject<dynamic>(json);    
                }
                return data;
            }

            public static async Task<dynamic> getDataFromServiceByCity(string cidade)
            {
                string AppId = "ead09a0fc5ec976294614400f3334d57";

                string url = string.Format("http://api.openweathermap.org/data/2.5/forecast/daily?q={0}&units-metric&cnt=1&APPID={1}", cidade.Trim(), appId);

                HttpClient client = new HttpClient();
                var response = await client.GetAsync(url);
                dynamic data = null;
                if(response != null)
                {
                    string json= response.Content.ReadAsStringAsync().Result;
                    data = JsonConvert.DeserializeObject(json);
                }
                return data;
            }
        }
    }
}
