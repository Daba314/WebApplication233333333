using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication233333333.Models
{
    public class Payment
    {
        [Key]
        public int PaymID { get; set; }
        public float Amount { get; set; }
        public String PaymentMethod { get; set; }
        public String CardHolderName { get; set; }
        public int CardNumber { get; set; }


    }
}

