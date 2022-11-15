using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace botWhatsApp.Services
{
    public class KnoledgeService
    {

        public async Task<string> Execute(string message)
        {
            string host = "https://botwhatsapp-lenresource.cognitiveservices.azure.com/language/:query-knowledgebases?projectName=chatBot-FC&api-version=2021-10-01&deploymentName=production";
            string auth = "Ocp-Apim-Subscription-Key: dcd372048b904c679f2b9da726fcaf29";

            RestClient client = new RestClient(host);
            RestRequest request = new RestRequest(Method.Post);
            request.AddHeader("Ocp-Apim-Subscription-Key", auth);
            request.AddHeader("content-type", "application/json");


        }

    }
}
