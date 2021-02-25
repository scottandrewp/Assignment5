using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4.Models
{
    public class Book
    {
        [Key]
        [Required]
        public int BookId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string AuthorFirstName { get; set; }

        [Required]
        public string AuthorLastName { get; set; }

        [Required]
        public string Publisher { get; set; }

        [Required]
        [RegularExpression("^[0-9]{3}-[0-9]{10}$", ErrorMessage ="ISBN must be in XXX-XXXXXXXXXX format")]
        public string ISBN { get; set; }

        [Required]
        public bool Fiction { get; set; }

        [Required]
        public string Genre { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public double? Price { get; set; }

        [Required]
        public int Pages { get; set; }
    }
}
