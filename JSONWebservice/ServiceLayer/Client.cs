using Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public static class Client
    {
        private static readonly string _appId = "7ce358bb58d74a8bb18136219eba2844";

        #region Public Methods

        public static CurrencyData.Root GetCurrency(string method)
        {
            CurrencyData.Root result = new CurrencyData.Root();
            using (WebClient webClient = new WebClient())
            {
                string url = string.Format("https://openexchangerates.org/api/{0}?app_id={1}&base=USD", method, _appId);

                string json = webClient.DownloadString(url);

                result = JsonConvert.DeserializeObject<CurrencyData.Root>(json);
            }
            return result;
        }

        #endregion
    }
}
