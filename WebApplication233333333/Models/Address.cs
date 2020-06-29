using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication233333333.Models
{
    public class Address
    {
        
            [Key]
            public int AddrID { get; set; }
            public String Country { get; set; }
            public String State { get; set; }
            public String City { get; set; }
            public String Street { get; set; }
            public String Appartment { get; set; }
        
    }
}

