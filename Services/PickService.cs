using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Scania.PickToLight.Models;

namespace Scania.PickToLight.Service
{
    public class PickService
    {
        private static string _url = @"http://pick.br.scania.com:80/facade";
        private static string _api = @"api/v1/public/vp";
        private static string _prodDataBase = "CUZCO";
        private static string _acpDataBase = "";

        public async Task<StationConfig> GetStationConfigAsync(string identify, string database = "CUZCO")
        {
            string path = $"{_url}/{_api}/getconfiguration/{database}/{identify}";

            try
            {
                using (HttpClient client = new HttpClient(new HttpClientHandler() { UseDefaultCredentials = true }))
                {
                    client.BaseAddress = new Uri(path);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage data = await client.GetAsync(path);
                    var response = await data.Content.ReadAsStringAsync();
                    if (response != null)
                    {
                        return JsonConvert.DeserializeObject<StationConfig>(response);
                    }

                }
            }
            catch (WebException exception)
            {
                throw new WebException("An error has occurred while calling GetStationConfigAsync method: " + exception.Message);
            }

            return null;

        }

        public async Task<Wagon> GetWagonAsync(string stationId, string database = "CUZCO")
        {
            string path = $"{_url}/{_api}/getwagon/{database}/{stationId}";

            try
            {
                using (HttpClient client = new HttpClient(new HttpClientHandler() { UseDefaultCredentials = true }))
                {
                    client.BaseAddress = new Uri(path);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage data = await client.GetAsync(path);
                    var response = await data.Content.ReadAsStringAsync();
                    if (response != null)
                    {
                        return JsonConvert.DeserializeObject<Wagon>(response);
                    }

                }
            }
            catch (WebException exception)
            {
                throw new WebException("An error has occurred while calling GetWagon method: " + exception.Message);
            }

            return null;

        }

        public async Task<GroupStation> GetGroupStationAsync(string groupId, string database = "CUZCO")
        {
            string path = $"{_url}/{_api}/getgroupstationbyid/{database}/{groupId}";

            try
            {
                using (HttpClient client = new HttpClient(new HttpClientHandler() { UseDefaultCredentials = true }))
                {
                    client.BaseAddress = new Uri(path);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage data = await client.GetAsync(path);
                    var response = await data.Content.ReadAsStringAsync();
                    if (response != null)
                    {
                        return JsonConvert.DeserializeObject<GroupStation>(response);
                    }

                }
            }
            catch (WebException exception)
            {
                throw new WebException("An error has occurred while calling GroupStation method: " + exception.Message);
            }

            return null;

        }

        public async Task<Log> FinishWagonAsync(Log log)
        {
            string path = $"{_url}/{_api}/log";            
            var postData = new Dictionary<string,string>();            

            try
            {
                using (HttpClient client = new HttpClient(new HttpClientHandler() { UseDefaultCredentials = true }))
                {                    
                    client.BaseAddress = new Uri(path);                                                            
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));                 

                    postData.Add("idWagon", Convert.ToString(log.IdWagon));
                    postData.Add("user", log.User);
                    postData.Add("justification", log.Justification);

                    FormUrlEncodedContent content = new FormUrlEncodedContent(postData);                                    

                    HttpResponseMessage data = await client.PostAsync(path, content);

                    string response = await data.Content.ReadAsStringAsync();

                    if (response != null)
                    {                                                                      
                        return JsonConvert.DeserializeObject<Log>(response);
                    }

                }
            }
            catch (WebException exception)
            {
                throw new WebException("An error has occurred while calling Log method: " + exception.Message);
            }

            catch (Exception ex)
            {
                throw new Exception("An Error Has Ocurred " + ex.Message);
            }

            return null;
        }

    }
}