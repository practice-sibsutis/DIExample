using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIExample.Test.Mocks
{
    public static class NotifyerMockFactory
    {
        public static INotifyer GetNotifyerMock()
        {
            var mock = new Mock<INotifyer>();
            mock.Setup(notifyer => notifyer.Send(It.IsAny<string>())).Verifiable();
            return mock.Object;
        }
    }
}
