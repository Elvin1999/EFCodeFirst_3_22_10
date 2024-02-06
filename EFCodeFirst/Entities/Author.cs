using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public int? Age { get; set; }
        public virtual ICollection<Book> Books { get; set; }

        public override string ToString()
        {
            return Firstname;
        }
    }
}
