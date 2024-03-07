using AbstractFactory;

Console.Title = "Abstract Factory";

BelgiumShoppingCartPurchaseFactory belgiumShoppingCartPurchaseFactory = new();
ShoppingCart shoppingCartForBelgium = new(belgiumShoppingCartPurchaseFactory);
shoppingCartForBelgium.CalculateCosts();

FranceShoppingCartPurchaseFactory franceShoppingCartPurchaseFactory = new();
ShoppingCart shoppingCartForFrance = new(franceShoppingCartPurchaseFactory);
shoppingCartForFrance.CalculateCosts();

Console.WriteLine("Press any key to terminate program.");
Console.ReadKey();