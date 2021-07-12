using Serilog;

namespace Services
{
    public interface IFaturaService
    {
    }

    public class FaturaService : IFaturaService
    {
        private readonly ILogger _logger;
        private readonly IWebApiService _apiService;

        public FaturaService(ILogger logger,IWebApiService apiService)
        {
            _logger = logger;
            _apiService = apiService;
        }
        
        
        
    }
}