using System.Collections.Generic;

namespace Client.Models
{
    public class User
    {
        public string ID { get; set; } 
        public string UserName { get; set; }
        public int Password { get; set; }
        public string Address { get; set; } 
        public int Phone { get; set; }
        public string Review { get; set; }
    }
}