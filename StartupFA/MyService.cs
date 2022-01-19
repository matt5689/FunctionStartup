using Microsoft.Extensions.Logging;

namespace StartupFA
{
    public class MyService : IMyService
    {
        private string _myValue;
        private ILogger _logger;

        public MyService(ILogger<Function1> logger)
        {
            _logger = logger;
        }

        public void MyServiceMethod(string myValue)
        {
            _logger.LogInformation(myValue);
        }
    }
}