using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication233333333.Models
{
    public class Evaluation
    {
        [Key]
        public int ClientEvalID { get; set; }
        public String SocialMedia { get; set; }
        public String Review { get; set; }
        public int ProductRating { get; set; }
        public int ServiceRating { get; set; }


    }
}
