using Bridge;

Console.Title = "Bridge";

NoCoupon noCoupon = new();
OneEuroCoupon oneEruoCoupon = new();

MeatBasedMenu meatBasedMenu = new(noCoupon);
Console.WriteLine($"Meat based menu, no coupon: {meatBasedMenu.CalculatePrice()} euro.");

meatBasedMenu = new(oneEruoCoupon);
Console.WriteLine($"Meat based menu, one euro coupon: {meatBasedMenu.CalculatePrice()} euro.");

VegetarianMenu vegetarianMenu = new(noCoupon);
Console.WriteLine($"Vegetarian menu, no coupon: {vegetarianMenu.CalculatePrice()} euro.");

vegetarianMenu = new(oneEruoCoupon);
Console.WriteLine($"Vegetarian menu, one euro coupon: {vegetarianMenu.CalculatePrice()} euro.");

Console.WriteLine(Environment.NewLine + "Press any key to terminate program.");
Console.ReadKey();