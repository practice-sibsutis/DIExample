using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIExample.Test.Mocks
{
    public static class LoggerMockFactory
    {
        public static ILogger GetLoggerMock()
        {
            var mock = new Mock<ILogger>();
            mock.Setup(logger => logger.Info(It.IsAny<string>())).Verifiable();
            mock.Setup(logger => logger.Warning(It.IsAny<string>())).Verifiable();
            mock.Setup(logger => logger.Error(It.IsAny<string>())).Verifiable();
            return mock.Object;
        }
    }
}
