using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using ChainSo.NET.Model.Error;
using Newtonsoft.Json;

namespace ChainSo.NET
{
    public abstract class AbstractClient
    {
        protected HttpClient _httpClient;

        #region Constructors

        public AbstractClient() : this(false) { }
        public AbstractClient(bool useDefaultProxy)
        {
            _httpClient = new HttpClient();
            if (useDefaultProxy)
            {
                HttpClientHandler handler = new HttpClientHandler();
                WebRequest.DefaultWebProxy.Credentials = CredentialCache.DefaultNetworkCredentials;
                handler.Proxy = WebRequest.DefaultWebProxy;
                _httpClient = new HttpClient(handler);
            }
            else
                _httpClient = new HttpClient();
        }

        #endregion Constructors

        #region Query Generic

        protected async Task<T> AnswerQuery<T, E>(HttpResponseMessage response)
        {
            string json = await response.Content.ReadAsStringAsync();
            if (response.IsSuccessStatusCode)
            {
                T success = JsonConvert.DeserializeObject<T>(json);
                return success;
            }
            E error = JsonConvert.DeserializeObject<E>(json);
            throw new ExceptionWithMessage<E>(error);
        }

        protected async Task<T> PostQuery<T, E>(string uri, List<KeyValuePair<string, string>> postParams)
        {
            var formContent = new FormUrlEncodedContent(postParams.ToArray());
            HttpResponseMessage response = await _httpClient.PostAsync(uri, formContent);
            return await AnswerQuery<T, E>(response);
        }

        protected async Task<T> GetQuery<T, E>(string uri)
        {
            HttpResponseMessage response = await _httpClient.GetAsync(uri);
            return await AnswerQuery<T, E>(response);
        }

        #endregion GetQuery Generic
    }
}
