using SessaoNove.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace SessaoNove.Entities
{
    internal class Order
    {

        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus status { get; set; }


        public override string ToString()
        {
            return Id
                + ", "
                + Moment
                + ", "
                + status;
        }
    }
}
