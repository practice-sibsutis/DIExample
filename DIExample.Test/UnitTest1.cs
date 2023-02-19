using DIExample.Test.Mocks;

namespace DIExample.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            ILogger logger = LoggerMockFactory.GetLoggerMock();
            INotifyer notifyer = NotifyerMockFactory.GetNotifyerMock();

            Invoice invoice = new Invoice(notifyer, logger);

            invoice.AddInvoice();
        }
    }
}