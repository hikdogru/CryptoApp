using RestSharp;

namespace Crypto.WebUI.Models
{
    public class RestApiModel : IRestApi
    {
        private readonly string _url;
        private readonly Method _method;

        public RestClient Client { get; set; }
        public RestRequest Request { get; set; }

        public RestApiModel(string url, Method method)
        {
            _url = url;
            _method = method;
            GetRestClient();
        }

        private void GetRestClient()
        {
            Client = new RestClient(_url);
            Client.Timeout = -1;
            GetRestRequest();
        }

        public void GetRestRequest()
        {
            Request = new RestRequest(_method);
        }

        public async Task<IRestResponse> GetRestResponseAsync()
        {
            return await Client.ExecuteAsync(Request);
        }

        public IRestResponse GetRestResponse()
        {
            return Client.Execute(Request);
        }

        public IRestResponse GetRestResponse(RestRequest request = null)
        {
            return Client.Execute(request);
        }

    }
}
