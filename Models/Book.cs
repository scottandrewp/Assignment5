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
        public string BookId { get; set; }

        public string Title { get; set; }

        public string AuthorFirstName { get; set; }

        public string AuthorLastName { get; set; }

        public string Publisher { get; set; }

        [RegularExpression("^[0-9]{3}-[0-9]{10}$")]
        public string ISBN { get; set; }

        public bool Fiction { get; set; }

        public string Genre { get; set; }

        [DataType(DataType.Currency)]
        public decimal? Price { get; set; }
    }
}
