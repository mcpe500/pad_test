using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAD_ROTIKITA.Contracts
{
    public class UserRole
    {
        public const string OWNER = "Owner";
        public const string KASIR = "Kasir";
        public const string ADMIN = "Admin";
    }
    public class UserVisible
    {
        public UserVisible(string user_id, string nama, string role)
        {
            this.user_id = user_id;
            this.nama = nama;
            this.role = role;
        }

        public string user_id { get; set; }
        public string nama { get; set; }
        public string role { get; set; }
    }
}
