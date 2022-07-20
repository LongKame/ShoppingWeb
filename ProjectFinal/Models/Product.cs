using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectFinal.Models
{
    public partial class Product
    {
        public Product()
        {
            CheckOuts = new HashSet<CheckOut>();
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Image { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int IdCategory { get; set; }
        public string Description { get; set; }

        public virtual Category IdCategoryNavigation { get; set; }
        public virtual ICollection<CheckOut> CheckOuts { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
