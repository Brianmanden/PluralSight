using Strategy;

Console.Title = "Strategy";

Order order = new("Marvin Software", 5, "Visual Studio License");
//order.ExportService = new CsvExportService();
//order.Export();
order.Export(new CsvExportService());

//order.ExportService = new JsonExportService();
//order.Export();
order.Export(new JsonExportService());

//order.ExportService = new XmlExportService();
//order.Export();
order.Export((XmlExportService)new());


Console.WriteLine(Environment.NewLine + "Press any key to terminate program.");
Console.ReadKey();