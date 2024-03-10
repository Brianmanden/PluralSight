namespace ClassAdapter
{
	public class CityFromExternalSystem
	{
		public string Name { get; set; }
		public string NickName { get; set; }
		public int Inhabitants { get; set; }

		public CityFromExternalSystem(string name, string nickName, int inhabitants)
		{
			Name = name;
			NickName = nickName;
			Inhabitants = inhabitants;
		}
	}

	/// <summary>
	/// Adaptee
	/// </summary>
	public class ExternalSystem
	{
		public CityFromExternalSystem GetCity()
		{
			return new CityFromExternalSystem("Antwerp", "'t Stad", 500000);
		}
	}

	public class City
	{
		public string FullName { get; set; }
		public long Inhabitants { get; set; }

		public City(string fullName, long inhabitants)
		{
			FullName = fullName;
			Inhabitants = inhabitants;
		}
	}

	/// <summary>
	/// Target
	/// </summary>
	public interface ICityAdapter
	{
		City GetCity();
	}

	public class CityAdapter : ExternalSystem, ICityAdapter
	{
		public City GetCity()
		{
			//call into external system
			CityFromExternalSystem cityFromExternalSystem = base.GetCity();

			//adapt from the CityExternalCity to a City
			return new City(
				$"{cityFromExternalSystem.Name} - {cityFromExternalSystem.NickName}",
				cityFromExternalSystem.Inhabitants
			);
		}
	}
}
