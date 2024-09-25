namespace Module5_6
{
    enum DelType
    {
        HomeDelivery = 1,
        ShopDelivery,
        PPDelivery
    }
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

    

    internal class Program
    {
        static Order<Delivery> MakeOrder()
        {
            var order = new Order<Delivery>();
            order.SetNumber();
            

            order.Delivery = new HomeDelivery();
            order.Delivery.Address = Console.ReadLine();
            

            return order;
        }
        static void Main(string[] args)
        {
            var Ord1 = MakeOrder();
            Ord1.DisplayAddress();
            Console.WriteLine(Ord1.number);

            Asus pc = new Asus();
            pc.Set();
            Console.WriteLine(pc.price);
            Console.WriteLine(pc.type);
            Console.WriteLine(pc.name);
            
            
        }

        
    }
}
