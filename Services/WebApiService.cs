using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RestSharp;

namespace Services
{
    public class WebApiService : IWebApiService
    {
        private readonly ILogger<WebApiService> _logger;
        private readonly IConfiguration _configuration;
        private readonly string _url;
        private readonly string _testUrl;
        private readonly string _dispatch;
        private readonly string _token;
        private readonly string _referrerToken;
        private readonly string _username;
        private readonly string _password;
        private readonly List<KeyValuePair<string, string>> _headers;
        private readonly RestClient _client;
        private readonly JsonSerializerSettings _defaultSettings;

        public WebApiService(ILogger<WebApiService> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;

            _url = configuration["EFaturaApi:Url"];
            _testUrl = configuration["EFaturaApi:TestUrl"];
            _dispatch = configuration["EFaturaApi:Dispatch"];
            _token = configuration["EFaturaApi:Token"];
            _referrerToken = configuration["EFaturaApi:ReferrerToken"];
            _username = configuration["EFaturaApi:Username"];
            _password = configuration["EFaturaApi:Password"];
            _client = new RestClient(_url);

            _headers = new List<KeyValuePair<string, string>>
            {
                new("Accept", "*/*"),
                new("Accept-Language", "tr,en-US;q=0.9,en;q=0.8"),
                new("Cache-Control", "no-cache"),
                new("Content-Type", "application/x-www-form-urlencoded;charset=UTF-8"),
                new("Pragma", "no-cache"),
                new("sec-fetch-mode", "cors"),
                new("sec-fetch-site", "same-origin"),
                new("User-Agent", "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_14_6) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/87.0.4280.67 Safari/537.36"),
            };

            _defaultSettings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                DefaultValueHandling = DefaultValueHandling.Include,
                TypeNameHandling = TypeNameHandling.None,
                NullValueHandling = NullValueHandling.Ignore,
                Formatting = Formatting.None,
                ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor
            };
        }

        public Task SetTestCredentialsAsync()
        {
            try
            {
                var path = System.IO.Path.Combine("earsiv-services", "esign");

                var request = new RestRequest(path, Method.POST);

                request.AddParameter("assoscmd", "kullaniciOner");

                request.AddParameter("rtype", "json");

                Task<IRestResponse> restResponse = _client.ExecuteAsync(request);

                var result = JsonConvert.DeserializeObject(restResponse.Result.Content, _defaultSettings); ///deserializer.Deserialize<RestResult<List<PbsUser>>>(restResponse);

                var isSuccessful = restResponse.Result.IsSuccessful;

                request.AddHeaders(_headers);
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message, e);
                throw;
            }

            return Task.CompletedTask;
        }

        public Task<TResponse> SendRequest<TResponse, TRequest>(TRequest request) where TResponse : class
        {
            
        }

        public Task<bool> Connect()
        {
            throw new NotImplementedException();
        }
    }


    public interface IWebApiService
    {
        public Task SetTestCredentialsAsync();

        public Task<bool> Connect();
    }
}