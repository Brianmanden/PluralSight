using Decorator;

Console.Title = "Decorator";

// instantiate mail services
CloudMailService cloudMailService = new();
cloudMailService.SendMail("Hello there from cloud :)");

OnPremiseMailService onPremiseMailService = new();
onPremiseMailService.SendMail("Hello there from premises :)");

// add behavior
StatisticsDecorator statisticsDecorator = new(cloudMailService);
statisticsDecorator.SendMail($"Hi there via {nameof(StatisticsDecorator)} wrapper");

// add behavior
MessageDatabaseDecorator messageDatabaseDecorator = new(onPremiseMailService);
messageDatabaseDecorator.SendMail($"Hi there via {nameof(MessageDatabaseDecorator)} wrapper, message 1.");
messageDatabaseDecorator.SendMail($"Hi there via {nameof(MessageDatabaseDecorator)} wrapper, message 2.");

foreach (string message in messageDatabaseDecorator.SentMessages)
{
	Console.WriteLine($"Stored message: \"{message}\"");
}

Console.WriteLine(Environment.NewLine + "Press any key to terminate program.");
Console.ReadKey();