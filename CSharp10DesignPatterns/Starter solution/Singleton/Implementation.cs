namespace Singleton
{
	/// <summary>
	/// Singleton
	/// https://app.pluralsight.com/library/courses/c-sharp-10-design-patterns/table-of-contents > Creational Pattern: Singleton
	/// </summary>
	public class Logger
	{
		private static Logger? _instance;

		public static Logger Instance
		{
			get
			{
				//lazy instatiation
				if (_instance is null)
				{
					_instance = new Logger();
				}

				return _instance;
			}
		}

		// Protected Constructor so the class cannot be instantiated but it can be subclassed.
		protected Logger()
		{

		}

		/// <summary>
		/// Singleton Operation
		/// </summary>
		/// <param name="message"></param>
		public void Log(string message)
		{
			Console.WriteLine($"Message to log: {message}");
		}
	}
}
