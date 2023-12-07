using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpUdemy_Secao04_Aulas.Entities_Aula132
{
    class OrderItem_132
    {
        public int Quantity { get; set; }
        public double Price { get; set; }

        public OrderItem_132()
        {
        }

        public OrderItem_132(int quantity, double price)
        {
            Quantity = quantity;
            Price = price;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }
    }
}
