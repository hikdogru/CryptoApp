using RestSharp;

namespace Crypto.WebUI.Models
{
    public interface IRestApi
    {
        RestClient Client { get; set; }
        RestRequest Request { get; set; }

        void GetRestRequest();
        IRestResponse GetRestResponse();
        IRestResponse GetRestResponse(RestRequest request = null);
        Task<IRestResponse> GetRestResponseAsync();
    }
}