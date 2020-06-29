using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication233333333.Models
{
    public class Client
    {
        [Key]
        public int ClientID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public int OrdID { get; set; }
        public int PaymID { get; set; }
        public int ClientEvalID { get; set; }
        public int AddrID { get; set; }


    }
}
