using System.Collections.Generic;

namespace AdminUserApp.Models
{
    public class RolAtama
    {
        public string RoleName { get; set; }
        public string UserName { get; set; }
        public List<Role> Roller { get; set; }
        public List<User> Kullanicilar { get; set; }
    }
}