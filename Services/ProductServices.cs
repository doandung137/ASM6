using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using jsonCategory.Adapters;
using jsonCategory.Models;
using jsonCategory.Pages;
using Newtonsoft.Json;
using ProductDetail = jsonCategory.Models.ProductDetail;

namespace jsonCategory.Services
{
    class ProductServices
    {
        private Adapter _adapter = new Adapter();

        public Adapter Adapter { get => _adapter; set => _adapter = value; }

        public async Task<ProductList> TodaySpecial()
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync(Adapter.TodaySpecial);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var stringContent = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ProductList>(stringContent);
            }
            return null;
        }

        public async Task<ProductDetail> ProductDetail(int id)
        {
            HttpClient httpClient = new HttpClient();
            var response = await httpClient.GetAsync(Adapter.ProductDetail(id));
            if (response.StatusCode == HttpStatusCode.OK)
            {
                var stringContent = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<ProductDetail>(stringContent);
            }
            return null;
        }

    }
}
