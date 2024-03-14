using Facade;

Console.Title = "Facade";

DiscountFacade facade = new();
Console.WriteLine($"Discount percentage for customder with id: 1: {facade.CalculateDiscountPercentage(1)}");
Console.WriteLine($"Discount percentage for customder with id: 10: {facade.CalculateDiscountPercentage(10)}");


Console.WriteLine(Environment.NewLine + "Press any key to terminate program.");
Console.ReadKey();