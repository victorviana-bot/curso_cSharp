using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpUdemy_Secao04_Aulas.Entities_Aula132
{
    class Product_132
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product_132()
        {
        }

        public Product_132(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
