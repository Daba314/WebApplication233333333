using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication233333333.Models
{
    public class Order
    {
        [Key]
        public int OrdID { get; set; }
        public String OrderStatus { get; set; }
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime ShippedDate { get; set; }
        public String Item { get; set; }
        public int Quantity { get; set; }

    }
}