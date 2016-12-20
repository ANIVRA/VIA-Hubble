using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using VIA.Models;

namespace VIA.Services
{
    public class CarService
    {

        const string carURL = "http://carinfoapis.azurewebsites.net/";
        HttpClient client = new HttpClient();


        public async Task<List<string>> GetYears()
        {
            // TODO: use GET to retrieve Years
            return JsonConvert.DeserializeObject<List<string>>(await client.GetStringAsync(carURL + "api/Cars/Years"));

        }

        public async Task<List<string>> GetMakes(string year)
        {

            string param = string.Format("?_year={0}", year);

            // TODO: use GET to retrieve Makes
            return JsonConvert.DeserializeObject<List<string>>(await client.GetStringAsync(carURL + "api/Cars/Makes/" + param));

        }

        public async Task<List<string>> GetModels(string year, string make)
        {
            //http://www.nhtsa.gov/webapi/api/Recalls/vehicle/modelyear/2000/make/saturn?format=xml

            string param = string.Format("?_year={0}&_make={1}", year, make);
            string nhtsaModels = string.Format("http://www.nhtsa.gov/webapi/api/Recalls/vehicle/modelyear/{0}/make/{1}?format=json", year, make);
            List<string> models = new List<string>();

            // TODO: use GET to retrieve Models
            try
            {
                RecallModel result = JsonConvert.DeserializeObject<RecallModel>(await client.GetStringAsync(nhtsaModels));

                foreach (var m in result.Results)
                {
                    models.Add(m.Model);
                }
                models.Add("via NHTSA");
            }
            catch (Exception ex1)
            {
                try
                {
                    models = JsonConvert.DeserializeObject<List<string>>(await client.GetStringAsync(carURL + "api/Cars/Models/" + param));
                    models.Add("via CUSTOM");
                }
                catch (Exception ex2) { }
            }

                return models;


        }

        public async Task<List<string>> GetTrims(string year, string make, string model)
        {
            string param = string.Format("?_year={0}&_make={1}&_model={2}", year, make, model);

            // TODO: use GET to retrieve Trims
            return JsonConvert.DeserializeObject<List<string>>(await client.GetStringAsync(carURL + "api/Cars/Trims/" + param));

        }
    }
}

