using System;


namespace TrabalhandoComArquivos
{
    class Products
    {
        public String Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Products(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double ValorTotal()
        {
            return Price * Quantity;
        }
    }
}
