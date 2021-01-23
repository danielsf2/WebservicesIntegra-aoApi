using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WebServiceConsumer.com.webservice.consumer.requests
{
    public class Requests
    {

        public static HttpResponseMessage GetRequest<T>(ref T Param, string url)
        {
            var client = new HttpClient();

            HttpResponseMessage response = new HttpResponseMessage() { StatusCode = HttpStatusCode.BadRequest };

            try
            {
                response = Task.Run(() => client.GetAsync(url)).Result;

                String ResultString = Task.Run(() => response.Content.ReadAsStringAsync()).Result;
                Param = JsonConvert.DeserializeObject<T>(ResultString);
            }
            //Esse exceção é disparada por falta de conexão com a Internet.
            catch (System.AggregateException)
            {
                response.StatusCode = HttpStatusCode.BadGateway;
                return response;
            }
            catch (System.TimeoutException)
            {
                return response;
            }
            //Erro ao serializar ou deserializar o JSON
            catch (Newtonsoft.Json.JsonException)
            {
                response.StatusCode = HttpStatusCode.PreconditionFailed;
                return response;
            }
            catch (System.Exception)
            {
                response.StatusCode = HttpStatusCode.PreconditionFailed;
                return response;
            }

            client.Dispose();

            return response;
        }//GetRequest

        public static HttpResponseMessage PostRequest<T, R>(T Parameters, ref R ParametersResponse, string url)
        {
            var client = new HttpClient();

            var JsonParameters = JsonConvert.SerializeObject(Parameters, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            JsonParameters.ToString();


            var strContent = new StringContent(JsonParameters, Encoding.UTF8, "application/json");

            HttpResponseMessage response = new HttpResponseMessage() { StatusCode = HttpStatusCode.BadRequest };

            try
            {
                response = Task.Run(() => client.PostAsync(url, strContent)).Result;

                String ResultString = Task.Run(() => response.Content.ReadAsStringAsync()).Result;
                ParametersResponse = JsonConvert.DeserializeObject<R>(ResultString);
            }
            //Esse exceção é disparada por falta de conexão com a Internet.
            catch (System.AggregateException)
            {
                response.StatusCode = HttpStatusCode.BadGateway;
                return response;
            }
            catch (System.TimeoutException)
            {
                return response;
            }
            //Erro ao serializar ou deserializar o JSON
            catch (Newtonsoft.Json.JsonException)
            {
                //response.StatusCode = HttpStatusCode.PreconditionFailed;
                return response;
            }
            catch (System.Exception)
            {
                response.StatusCode = HttpStatusCode.PreconditionFailed;
                return response;
            }
            client.Dispose();

            return response;
        }//PostRequest

    }//class Requests
}
