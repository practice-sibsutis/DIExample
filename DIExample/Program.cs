// See https://aka.ms/new-console-template for more information
using DIExample;
using Microsoft.Extensions.DependencyInjection;

IServiceCollection services = new ServiceCollection();

services = services.AddTransient<ILogger, ConsoleLogger>()
    .AddTransient<INotifyer, EmailNotifyer>(x => new EmailNotifyer("email@yandex.ru"))
    .AddTransient<Invoice>();

using var serviceProvider = services.BuildServiceProvider();

INotifyer notifyer = serviceProvider.GetService<INotifyer>();
ILogger logger = serviceProvider.GetService<ILogger>();

Invoice invoice = serviceProvider.GetService<Invoice>();

invoice.Date = DateTime.Now;
invoice.TotalAmount = 100;

invoice.AddInvoice();
