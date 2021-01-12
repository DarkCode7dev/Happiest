using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApI.Models
{
    public class Members
    {
        [Key]
        public int GMId { get; set; }
        public string CardOwnerName { get; set; }
        public string CardNumber { get; set; }
        public string ExpirationDate { get; set; }

        public int Money { get; set; }
    }
}
