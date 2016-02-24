using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Amin.Controllers
{
    public sealed class DBDAL
    {
        private static DBDAL instance = null;

        private DBDAL()
        {
        }

        public static DBDAL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DBDAL();

                    //Init();
                }
                return instance;
            }
        }

        public List<string> GetPersonList()
        {
            List<string> retVal = null;

            try
            {
                HttpClient client = new HttpClient();
                string AminDBServiceUrl = ConfigurationManager.AppSettings["AminDBServiceUrl"];
                string url = "api/person";
                client.BaseAddress = new Uri(AminDBServiceUrl);

                // Add an Accept header for JSON format.
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = client.GetAsync(url).Result;  // Blocking call!
                if (response.IsSuccessStatusCode)
                {
                    var result = response.Content.ReadAsAsync<List<string>>().Result;
                    if (result != null)
                    {
                        retVal = result;
                    }
                }

                //log.Info("GetRankings. timeFrame: " + timeFrame); 
            }
            catch (Exception Ex)
            {
                //log.Error("GetRankings failed. ", Ex);
            }

            return retVal;
        }

        public bool AddPerson(string person)
        {
            bool retVal = false;

            try
            {
                using (var client = new WebClient())
                {
                    var values = new NameValueCollection{};
                    string AminDBServiceUrl = ConfigurationManager.AppSettings["AminDBServiceUrl"];
                    string url = AminDBServiceUrl + "api/person?person=" + person;
                    var bytes = client.UploadValues(url, "POST", values);
                    var response = Encoding.UTF8.GetString(bytes);
                    if (response.Equals("true"))
                    {
                        retVal = true;
                    }
                }

              //  log.Info("Follow. followee: " + request.followee + ", action: " + request.action);
               
            }
            catch (Exception ex)
            {
              //  log.Error("Follow. . followee: " + request.followee + ", action: " + request.action + ". ", ex);
            }

            return retVal;
        }

        public void Init()
        {
        }

    }
}