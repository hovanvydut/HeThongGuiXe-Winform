using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json;

namespace HeThongGiuXe
{
    class APIPlateRecognizer
    {
        private String Host;
        private String Token;
        private static readonly HttpClient client = new HttpClient();
        private APIPlateRecognizer()
        {
            //TODO: read token + host from appconfig
            this.Host = ConfigurationManager.AppSettings["host_API"];
            this.Token = ConfigurationManager.AppSettings["token_API"];
            client.DefaultRequestHeaders.Add("Authorization", "Token " + this.Token);
        }
        public async System.Threading.Tasks.Task<IList<Result>> ReadPlateAsync(String filePath)
        {
            List<Result> results = new List<Result>();
            // -----------------------------------------
            // Create form
            MultipartFormDataContent multiForm = new MultipartFormDataContent();
            // Text params
            multiForm.Add(new StringContent("regions"), "vn");
            multiForm.Add(new StringContent("mmc"), "false");
            // File params
            FileStream fs = File.OpenRead(filePath);
            multiForm.Add(new StreamContent(fs), "upload", Path.GetFileName(filePath));
            // Request
            try
            {
                HttpResponseMessage response = await client.PostAsync(this.Host + @"/v1/plate-reader/", multiForm);
                string responseString = await response.Content.ReadAsStringAsync();
                PlateReaderResult json = JsonConvert.DeserializeObject<PlateReaderResult>(responseString);
                return json.Results;
            } catch (Exception err)
            {
                Console.WriteLine("ERROR API:" + err.Message);
                return null;
            }
        }
        // ------------------ Singleton ----------------------
        public static APIPlateRecognizer _Instance;
        public static APIPlateRecognizer Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new APIPlateRecognizer();
                }
                return _Instance;
            }
        }
    }
}
