// See https://aka.ms/new-console-template for more information
using DatabaseFirstSample.Console.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

Console.WriteLine("EF Core Demo");

var serviceProvider = new ServiceCollection();
var configuration = new ConfigurationBuilder()
    .AddJsonFile("appSettings.json", false, false)
    .AddUserSecrets(Assembly.GetExecutingAssembly(), true)
    .Build();

string connectionString = String.Format(configuration.GetConnectionString("AdventureWorksConnection"), 
    configuration["SQL:server"], 
    configuration["SQL:AWDatabase"], 
    configuration["SQL:username"], 
    configuration["SQL:password"]);
serviceProvider
    .AddDbContext<AdventureWorksDbContext>(options =>
        options.UseSqlServer(connectionString)
    );

var provider = serviceProvider.BuildServiceProvider();

var context = provider.GetService<AdventureWorksDbContext>();

var Products = context.Products
    .Where(x=>x.Color.Equals("Silver"))
    .ToList();

var productExists = context.Products
    .Any(x => x.Name.Equals("Bearing Ball"));

var productCostCategorywise = context.Products
    .GroupBy(x=>x.ProductSubcategory.Name)
    .Select(x=>new { Amount = x.Sum(y=>y.ListPrice), Category=x.Key })
    .ToList();

Console.ReadKey();
