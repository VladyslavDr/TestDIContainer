using TestDIContainer.Loggers;

namespace TestDIContainer
{
    public class Service : IService
    {
        private readonly ILogger _logger;

        public Service(ILogger logger)
        {
            _logger = logger;
        }

        public void Method()
        {
            _logger.Log($"{nameof(Service)} is running...");
        }
    }
}