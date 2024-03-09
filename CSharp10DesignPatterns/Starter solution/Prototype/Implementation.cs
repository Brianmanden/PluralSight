using System.Text.Json;

namespace Prototype
{
	/// <summary>
	/// Prototype
	/// </summary>
	public abstract class Person
	{
		public abstract string Name { get; set; }

		public abstract Person Clone(bool deepClone);
	}

	/// <summary>
	/// ConcretePrototype1
	/// </summary>
	public class Manager : Person
	{
		public override string Name { get; set; }

		public Manager(string name)
		{
			Name = name;
		}

		public override Person Clone(bool deepClone = false)
		{
			if (deepClone)
			{
				string objectAsJson = JsonSerializer.Serialize(this);
				return JsonSerializer.Deserialize<Manager>(objectAsJson);
			}

			return (Person)MemberwiseClone();
		}
	}

	/// <summary>
	/// ConcretePrototype2
	/// </summary>
	public class Employee : Person
	{
		public Manager Manager { get; set; }
		public override string Name { get; set; }

		public Employee(string name, Manager manager)
		{
			Name = name;
			Manager = manager;
		}

		public override Person Clone(bool deepClone = false)
		{
			//if (deepClone)
			//{
			//	// Be aware that the BinaryFormatter is NOT secure.
			//	// More info here: https://aka.ms/binaryformatter
			//	BinaryFormatter binaryFormatter = new();
			//	using (MemoryStream memoryStream = new())
			//	{
			//		binaryFormatter.Serialize(memoryStream, this);
			//		memoryStream.Seek(0, SeekOrigin.Begin);
			//		return (Person)binaryFormatter.Deserialize(memoryStream);
			//	}
			//}

			if (deepClone)
			{
				string objectAsJson = JsonSerializer.Serialize(this);
				return JsonSerializer.Deserialize<Employee>(objectAsJson);
			}

			return (Person)MemberwiseClone();
		}
	}
}
