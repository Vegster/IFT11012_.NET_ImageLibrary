using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ImageSortLibrary.Model;

namespace ImageSortLibrary.UWP.DataSource
{
    class Pictures
    {
        public static Pictures Instance { get; } = new Pictures();


        private const string baseUri = "http://localhost:51357/api/";

        HttpClient _client;

        private Pictures()
        {
            _client = new HttpClient
            {
                BaseAddress = new System.Uri(baseUri)
            };
        }

        public async Task<Picture[]> GetPictures()
        {
            var json = await _client.GetStringAsync("pictures").ConfigureAwait(false);
            Picture[] pictures = JsonConvert.DeserializeObject<Picture[]>(json);
            return pictures;
        }

        public async Task<bool> DeletePictures(Picture picture)
        {
            var response = await _client.DeleteAsync($"pictures\\{picture.PictureId}").ConfigureAwait(false);
            return response.IsSuccessStatusCode || response.StatusCode == System.Net.HttpStatusCode.NotFound;
            
        }

        public async Task<bool> AddPictures(Picture picture)
        {
            string postBody = JsonConvert.SerializeObject(picture);
            var response = await _client.PostAsync("pictures", new StringContent(postBody, Encoding.UTF8, "application/json")).ConfigureAwait(false);
            return response.IsSuccessStatusCode;
        }

        //TODO: Check if this works
        public async Task<bool> UpdatePicture(Picture picture)
        {
            string postBody = JsonConvert.SerializeObject(picture);
            var response = await _client.PutAsync(($"pictures\\{picture.PictureId}"), new StringContent(postBody, Encoding.UTF8, "application/json")).ConfigureAwait(false);
            return response.IsSuccessStatusCode; 
        }
        
    }
}
