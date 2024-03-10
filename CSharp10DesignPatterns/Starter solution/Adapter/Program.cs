//using Adapter;
using ClassAdapter;

Console.Title = "Adapter";

//object adapter example
ICityAdapter adapter = new CityAdapter();
City city = adapter.GetCity();

Console.WriteLine($"{city.FullName}, {city.Inhabitants}");

Console.WriteLine(Environment.NewLine + "Press any key to terminate program.");
Console.ReadKey();