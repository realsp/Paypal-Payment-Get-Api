using PayPalInt.ApiUtils;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Net;
using System.Text.RegularExpressions;

namespace PayPalInt.ApiUtils.Invokers
{
    class PayPalInvoker
    {

        public static T HttpPost<T> (string UrlSandBoxPayPal, string sessionID, out HttpStatusCode statusCode)
        {
            try
            {
                var client = new RestClient();
                var request = new RestRequest(UrlSandBoxPayPal, DataFormat.Json);

                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Accept", "application/json");
                request.AddHeader("Authorization", "PayPalClientID:PayPalSecret");



                
            }
        }
    }
}
