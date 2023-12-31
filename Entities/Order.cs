﻿using System;
using CursoCSharpUdemy_Secao04_Aulas.Entities.Enums;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharpUdemy_Secao04_Aulas.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id
                + ", "
                + Moment
                + ", "
                + Status;
        }

    }
}
