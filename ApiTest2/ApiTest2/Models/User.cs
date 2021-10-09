using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTest2.Models
{
    public class User
    {
        // prop + tab + tab
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public byte[] Picture { get; set; } 
    }
}
