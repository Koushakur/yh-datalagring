using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Shared.Contexts;

var builder = Host.CreateDefaultBuilder();

builder.ConfigureServices(services => {
    services.AddDbContext<DataContext>(x => x.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\YH\04-Datalagring\inlamningsuppgift\DatabaseManagement\Shared\Data\localDB.mdf;Integrated Security=True;Connect Timeout=30"));
});

builder.Build();

Console.ReadKey();