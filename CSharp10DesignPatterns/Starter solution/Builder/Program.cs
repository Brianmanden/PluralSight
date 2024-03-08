using BuilderPattern;

Console.Title = "Builder";

Garage garage = new();

MiniBuilder miniBuilder = new MiniBuilder();
BMWBuilder BMWBuilder = new BMWBuilder();


garage.Construct(miniBuilder);
Console.WriteLine(miniBuilder.Car.ToString());
// or
//garage.Show();

garage.Construct(BMWBuilder);
//Console.WriteLine(BMWBuilder.Car.ToString());
// or
garage.Show();

Console.WriteLine("Press any key to terminate program.");
Console.ReadKey();