using Generic.Entities;
using Generic.Services;
using System.Globalization;

List<Product> list = new List<Product>();

Console.Write("Enter N ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] vetProduct = Console.ReadLine().Split(',');
    string name = vetProduct[0];
    double price = double.Parse(vetProduct[1], CultureInfo.InvariantCulture);
    list.Add(new Product(name, price));
}

var calculationService = new CalculationService();
var product = calculationService.Max(list);

Console.Write("Max:");
Console.WriteLine(product);

