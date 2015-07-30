using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookService.Models
{
    public class Author
    {
        public int Id { get; set; } //primary key column of database
        [Required]
        public string Name { get; set; }
    }
}