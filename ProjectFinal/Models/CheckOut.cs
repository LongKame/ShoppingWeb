using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectFinal.Models
{
    public partial class CheckOut
    {
        public int Id { get; set; }
        public int IdProduct { get; set; }
        public int IdAccount { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }

        public virtual Account IdAccountNavigation { get; set; }
        public virtual Product IdProductNavigation { get; set; }
    }
}
