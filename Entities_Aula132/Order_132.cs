using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;
using CursoCSharpUdemy_Secao04_Aulas.Entities_Aula132.Enums_132;
using CursoCSharpUdemy_Secao04_Aulas.Entities_Aula132;

namespace CursoCSharpUdemy_Secao04_Aulas.Entities_Aula132
{
    class Order_132
    {
        public DateTime Moment { get; set; }
        public OrderStatus_132 Status { get; set; }
        public List<OrderItem_132> OrderItem { get; set; } = new List<OrderItem_132>();
        public Product_132 Product { get; set; }
        public Client_132 Client { get; set; }

        public Order_132()
        {
        }

        public Order_132(DateTime moment, OrderStatus_132 status, Product_132 product, Client_132 client)
        {
            Moment = moment;
            Status = status;
            Product = product;
            Client = client;
        }

        public void AddOrderItem(OrderItem_132 orderItem)
        {
            OrderItem.Add(orderItem);
        }

        public void RemoveOrderItem(OrderItem_132 orderItem)
        {
            OrderItem.Remove(orderItem);
        }

        public double Total()
        {
            double tot = 0.0;
            foreach (OrderItem_132 orderItem in OrderItem)
            {
                tot += orderItem.SubTotal();
            }
            return tot;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.Append(Client.Name);
            //sb.Append($" ({Client.BirthDate.ToString("dd/MM/yyyy")}) - ");
            sb.AppendLine(Client.Email);
            sb.AppendLine("Order itens: ");
            foreach (OrderItem_132 o in OrderItem)
            {
                sb.Append(Product.Name);
                sb.Append(", $");
                sb.Append(o.Price.ToString("F2", CultureInfo.InvariantCulture));
                sb.Append(", Quantity: ");
                sb.Append(o.Quantity);
                sb.Append(", Subtotal: $");
                sb.AppendLine(o.SubTotal().ToString("F2", CultureInfo.InvariantCulture));
            }
            sb.Append("Total price: $ ");
            sb.AppendLine(Total().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();

        }



    }
}
