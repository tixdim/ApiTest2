using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTest2.Models
{
    public class Note
    {
        public int Id { get; set; }
        // prop + tab + tab
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? ChangeDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
