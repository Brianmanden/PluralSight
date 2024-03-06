using FactoryMethod;

Console.Title = "Factory Method";

string countryIdentifier = "BE";

List<DiscountFactory> factories = new List<DiscountFactory>{
	new CodeDiscountFactory(Guid.NewGuid()),
	new CountryDiscountFactory( countryIdentifier),
};

foreach (DiscountFactory factory in factories)
{
	var discountService = factory.CreateDiscountService();

	Console.WriteLine($"Percentage {discountService.DiscountPercentage} coming from {discountService}");
}

Console.WriteLine("Press any key to terminate program.");
Console.ReadKey();