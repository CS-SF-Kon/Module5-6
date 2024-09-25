using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5_6
{
    internal class Order<TDelivery> where TDelivery : Delivery
    {
        public TDelivery Delivery;

        private Guid Number;

        public Inventory[] orderParts;
        public Guid number
        {
            get
            {
                return Number;
            }
            set
            {
                Number = value;
            }
        }
        public void SetNumber()
        {
            number = Guid.NewGuid();
        }
        

        public string Description;

        public void DisplayAddress()
        {
            Console.WriteLine(Delivery.Address);
        }

        // ... Другие поля
    }
    /// <summary>
    /// класс описывает общий инвентарь
    /// </summary>
    abstract class Inventory
    {
        public string type;
        public string name;
        public float price;
        public virtual void Set()
        {
            type = default;
            name = default;
            price = default;
        }
    }
    class PC : Inventory
    {
        public override void Set()
        {
            type = "PC";
        }
    }

    class Asus : PC
    {
        public override void Set()
        {
            name = "Asus PC";
            price = 499.9F;
        }
    }
    class Laptop : Inventory
    {
        public override void Set()
        {
            type = "Laptop";
        }
    }
    class Additional : Inventory
    {
        public override void Set()
        {
            type = "Additional";
        }
    }
}
