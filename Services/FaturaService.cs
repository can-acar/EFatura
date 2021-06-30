using Serilog;

namespace Services
{
    public interface IFaturaService
    {
    }

    public class FaturaService : IFaturaService
    {
        private readonly ILogger _logger;

        public FaturaService(ILogger logger)
        {
            _logger = logger;
        }
    }
}