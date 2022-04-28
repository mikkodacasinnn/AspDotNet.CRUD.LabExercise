using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customers.Data.Models
{
    public class CustomerEntity : BaseEntity
    {
        [Required]
        [MinLength(2)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2)]
        public string LastName { get; set; }

        [Required]
        [MinLength(4)]
        public string Address { get; set; }

        [Required]
        [RegularExpression("([0-9]+)")]
        [MinLength(11)]
        public string Phone { get; set; }

    }
}
