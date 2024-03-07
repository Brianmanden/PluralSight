namespace AbstractFactory
{

	public interface IShoppingPurchaseFactory
	{
		IDiscountService CreateDiscountService();
		IShippingCostsService CreateShippingCostsService();
	}

	/// <summary>
	/// AbstractProduct
	/// </summary>
	public interface IDiscountService
	{
		int DiscountPercentage { get; }
	}

	/// <summary>
	/// AbstractProduct
	/// </summary>
	public interface IShippingCostsService
	{
		decimal ShippingCosts { get; }
	}

	/// <summary>
	/// ConcreteProduct
	/// </summary>
	public class BelgiumDiscountService : IDiscountService
	{
		public int DiscountPercentage => 20;
	}

	/// <summary>
	/// ConcreteProduct
	/// </summary>
	public class FranceDiscountService : IDiscountService
	{
		public int DiscountPercentage => 10;
	}

	/// <summary>
	/// ConcreteProduct
	/// </summary>
	public class BelgiumShippingCostService : IShippingCostsService
	{
		public decimal ShippingCosts => 20;
	}

	/// <summary>
	/// ConcreteProduct
	/// </summary>
	public class FranceShippingCostService : IShippingCostsService
	{
		public decimal ShippingCosts => 25;
	}

	/// <summary>
	/// ConcreteFactory
	/// </summary>
	public class BelgiumShoppingCartPurchaseFactory : IShoppingPurchaseFactory
	{
		public IDiscountService CreateDiscountService()
		{
			return new BelgiumDiscountService();
		}

		public IShippingCostsService CreateShippingCostsService()
		{
			return new BelgiumShippingCostService();
		}
	}

	/// <summary>
	/// ConcreteFactory
	/// </summary>
	public class FranceShoppingCartPurchaseFactory : IShoppingPurchaseFactory
	{
		public IDiscountService CreateDiscountService()
		{
			return new FranceDiscountService();
		}

		public IShippingCostsService CreateShippingCostsService()
		{
			return new FranceShippingCostService();
		}
	}

	public class ShoppingCart
	{
		private readonly IDiscountService _discountService;
		private readonly IShippingCostsService _shippingCostsService;
		private int _orderCosts;

		public ShoppingCart(IShoppingPurchaseFactory factory)
		{
			_discountService = factory.CreateDiscountService();
			_shippingCostsService = factory.CreateShippingCostsService();

			// Assumption that total ordercost is 200
			_orderCosts = 200;
		}

		public void CalculateCosts()
		{
			Console.WriteLine($"Total costs = " +
			$"{_orderCosts - (_orderCosts / 100 * _discountService.DiscountPercentage) + _shippingCostsService.ShippingCosts}");
		}
	}
}
