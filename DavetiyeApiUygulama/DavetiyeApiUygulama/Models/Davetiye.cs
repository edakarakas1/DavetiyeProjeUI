using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DavetiyeApiUygulama.Models
{
    public class Davetiye
    {
        public int Id { get; set; }
        
        public string Ad { get; set; }
 
        public string Email { get; set; }
       
        public bool KatilimaDurumu { get; set; }
    }
}
