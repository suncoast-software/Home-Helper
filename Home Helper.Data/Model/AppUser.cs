using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Helper.Data.Model
{
   public class AppUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PasswordHash { get; set; }
        public Rank Rank { get; set; }
        public DateTime Created { get; set; }
        public ICollection<Payee> Payees { get; set; }
    }
}
