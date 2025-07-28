using System.Threading.Tasks.Dataflow;

namespace Types_of_products
{
    public class Product
    {
        public string name { get; set; }
        public int quantity { get; set; }

        public decimal price { get; set; }

        //constructor
        public Product(string name, int quantity, decimal price)
        {
            this.name = name;
            this.quantity = quantity;
            this.price = price;
        }

        public override string ToString()
        {
            return $"{name},{quantity},{price}";
        }

    }
}