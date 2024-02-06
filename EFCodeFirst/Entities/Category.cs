using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst.Entities
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30,ErrorMessage = "Category name should be 30 characters or less")]
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
