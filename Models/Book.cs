using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

//Nicholas Applegate, 1-3

namespace OnlineBookstore.Models
{
    public class Book
    {
        // Add all attributes, require all except middle name
        [Required]
        public string Title { get; set; }

        [Required]
        public string AuthorFirstName { get; set; }

        [Required]
        public string AuthorLastName { get; set; }

        public string AuthorMiddleName { get; set; }

        [Required]
        public string Publisher { get; set; }

        //Add regular expression to ensure ISBN added in correct format
        [Required, RegularExpression(@"^[0-9]{3}-?[0-9]{10}$",
         ErrorMessage = "Enter a valid ISBN: ###-##########")]
        public string ISBN { get; set; }

        //Establish BookId as a generated primary key
        [Required, Key]
        public int BookId { get; set; }

        [Required]
        public string Classification { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public int NumberOfPages { get; set; }
    }
}
