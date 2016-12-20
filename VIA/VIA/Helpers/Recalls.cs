using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using MvvmHelpers;
using System.Net.Http;
using Newtonsoft.Json;
using Acr.UserDialogs;
using VIA.Model.BingSearch;
using VIA.Services;
using VIA.Model;

namespace VIA.Helpers
{
    public class RecallSearch
    {
        public ObservableRangeCollection<carRecall> Recalls { get; }

        public RecallSearch()
        {
            Recalls = new ObservableRangeCollection<carRecall>();
        }

        public async Task<ObservableRangeCollection<carRecall>> GetRecallsAsync(string year, string make, string model)
        {
            //Bing Image API
            var url = $"http://www.nhtsa.gov/webapi/api/Recalls/vehicle" +
                      $"/modelyear/" + year +
                      $"/make/" + make +
                      $"/model/" + model +
                      $"?format=json"; 

            try
            {
                using (var client = new HttpClient())
                {
                    var json = await client.GetStringAsync(url);

                    var result = JsonConvert.DeserializeObject<List<carRecall>>(json);

                    Recalls.ReplaceRange(result.Select(i => new carRecall
                    {
                        Count = i.Count,
                        Message = i.Message,
                        Results = i.Results
                    }));
                }
            }
            catch (Exception ex)
            {
                await UserDialogs.Instance.AlertAsync("Unable to get recalls: " + ex.Message);
                return null;
            }

            return Recalls;
        }

    }
}

