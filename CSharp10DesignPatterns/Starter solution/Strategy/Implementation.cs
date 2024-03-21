namespace Strategy
{
	/// <summary>
	/// Strategy
	/// </summary>
	public interface IExportService
	{
		public void Export(Order order);
	}

	/// <summary>
	/// ConcreteStrategy
	/// </summary>
	public class JsonExportService : IExportService
	{
		public void Export(Order order)
		{
			Console.WriteLine($"Exporting {order.Name} to JSON.");
		}
	}

	/// <summary>
	/// ConcreteStrategy
	/// </summary>
	public class XmlExportService : IExportService
	{
		public void Export(Order order)
		{
			Console.WriteLine($"Exporting {order.Name} to XML.");
		}
	}

	/// <summary>
	/// ConcreteStrategy
	/// </summary>
	public class CsvExportService : IExportService
	{
		public void Export(Order order)
		{
			Console.WriteLine($"Exporting {order.Name} to CSV.");
		}
	}

	/// <summary>
	/// Context
	/// </summary>
	public class Order
	{
		public string Customer { get; set; }
		public int Amount { get; set; }
		public string Name { get; set; }
		public string? Description { get; set; }
		//public IExportService ExportService { get; set; }

		public Order(string customer, int amount, string name)
		//public Order(string customer, int amount, string name, IExportService exportService)
		{
			Customer = customer;
			Amount = amount;
			Name = name;
			//ExportService = new CsvExportService();
			//ExportService = exportService;
		}

		//public void Export()
		//{
		//	ExportService?.Export(this);
		//}

		public void Export(IExportService exportService)
		{
			if (exportService is null)
			{
				throw new NullReferenceException(nameof(exportService));
			}

			exportService.Export(this);
		}
	}


}
