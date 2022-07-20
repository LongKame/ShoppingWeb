using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectFinal.Models
{
    public partial class Account
    {
        public Account()
        {
            CheckOuts = new HashSet<CheckOut>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int IdRole { get; set; }

        public virtual Role IdRoleNavigation { get; set; }
        public virtual ICollection<CheckOut> CheckOuts { get; set; }
    }
}
