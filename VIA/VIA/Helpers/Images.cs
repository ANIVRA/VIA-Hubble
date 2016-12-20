﻿using System;
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
    public class ImagesSearch
    {
        public ObservableRangeCollection<ImageResult> Images { get; }

        public ImagesSearch()
        {
            Images = new ObservableRangeCollection<ImageResult>();
        }

        public async Task<ObservableRangeCollection<ImageResult>> SearchForImagesAsync(string query)
        {
            //Bing Image API
            var url = $"https://api.cognitive.microsoft.com/bing/v5.0/images/" +
                      $"search?q={WebUtility.UrlEncode(query)}" +
                      $"&count=20&offset=0&mkt=en-us&safeSearch=Strict";

            var requestHeaderKey = "Ocp-Apim-Subscription-Key";
            var requestHeaderValue = CognitiveServicesKeys.BingSearch;
            try
            {
                using (var client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add(requestHeaderKey, requestHeaderValue);

                    var json = await client.GetStringAsync(url);

                    var result = JsonConvert.DeserializeObject<SearchResult>(json);

                    Images.ReplaceRange(result.Images.Select(i => new ImageResult
                    {
                        ContextLink = i.HostPageUrl,
                        FileFormat = i.EncodingFormat,
                        ImageLink = i.ContentUrl,
                        ThumbnailLink = i.ThumbnailUrl,
                        Title = i.Name
                    }));
                }
            }
            catch (Exception ex)
            {
                await UserDialogs.Instance.AlertAsync("Unable to query images: " + ex.Message);
                return null;
            }

            return Images;
        }

    }
}

