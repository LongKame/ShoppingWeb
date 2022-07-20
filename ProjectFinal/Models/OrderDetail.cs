using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectFinal.Models
{
    public partial class OrderDetail
    {
        public int Id { get; set; }
        public int IdProduct { get; set; }
        public int Quantity { get; set; }

        public virtual Product IdProductNavigation { get; set; }
    }
}
