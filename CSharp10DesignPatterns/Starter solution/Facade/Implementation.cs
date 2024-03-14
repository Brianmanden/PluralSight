namespace Facade
{
    /// <summary>
    /// Subsystem class
    /// </summary>
    public class OrderService
    {
        public bool HasEnoughOrders(int customerId)
        {
            //fake calculation for demo purposes
            return (customerId > 5);
        }
    }

    /// <summary>
    /// Subsystem class
    /// </summary>
    public class CustomerDiscountService
    {
        public double CalculateDiscountBase(int customerId)
        {
            //fake calculation for demo purposes
            return (customerId > 8) ? 10 : 20;
        }
    }

    /// <summary>
    /// Subsystem class
    /// </summary>
    public class DayOfTheWeekFactorService
    {
        public double CalculateDayOfTheWeekFactor()
        {
            switch (DateTime.UtcNow.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                case DayOfWeek.Saturday:
                    return 0.8;
                default:
                    return 1.2;
            }
        }
    }

    /// <summary>
    /// Facade
    /// </summary>
    public class DiscountFacade
    {
        private readonly OrderService _orderService = new();
        private readonly CustomerDiscountService _customerDiscountBaseService = new();
        private readonly DayOfTheWeekFactorService _dayOfTheWeekFactorService = new();

        public double CalculateDiscountPercentage(int customerId) {
            if (!_orderService.HasEnoughOrders(customerId))
            {
                return 0;
            }

            return _customerDiscountBaseService.CalculateDiscountBase(customerId) * _dayOfTheWeekFactorService.CalculateDayOfTheWeekFactor();
        }
    }
}
