namespace Module5_6
{
    enum HomeDelCity
    {
        Moscow,
        St_Petersburg,
        Kazan
    }

    enum PPDelCity
    {
        Moscow,
        St_Petersburg,
        Kazan,
        Omsk,
        Volgograd
    }

    enum ShopDelCity
    {
        Moscow,
        St_Petersburg,
        Kazan,
        Novosibirsk,
        Vladivostok
    }

    abstract class Delivery
    {
        public string Address;
    }

    class HomeDelivery : Delivery
    {
        public HomeDelCity City;
    }

    class PickPointDelivery : Delivery
    {
        public PPDelCity City;
    }

    class ShopDelivery : Delivery
    {
        public ShopDelCity City;
    }

    class Order<TDelivery, TStruct> where TDelivery : Delivery
    {
        public TDelivery Delivery;

        public Guid Number;

        public string Description;

        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }

        // ... Другие поля
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Order<HomeDelivery, int> Ord1 = new();
            
            Ord1.Number = Guid.NewGuid();
            Console.WriteLine(Ord1.Number);
            Ord1.Delivery.City = HomeDelCity.Kazan;

            
            Console.WriteLine(Ord1.Delivery.City);

        }
    }
}
