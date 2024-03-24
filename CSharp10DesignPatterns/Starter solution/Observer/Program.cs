using Observer;

Console.Title = "Observer";

TicketStockService ticketStockService = new();
TicketResellerService ticketResellerService = new();
OrderService orderService = new();

// add two observers
orderService.AddObserver(ticketStockService);
orderService.AddObserver(ticketResellerService);

// notify
orderService.CompleteTicketSale(1, 2);

Console.WriteLine();

// remove observer
orderService.RemoveObserver(ticketResellerService);

// notify
orderService.CompleteTicketSale(2, 3);

Console.WriteLine(Environment.NewLine + "Press any key to terminate program.");
Console.ReadKey();