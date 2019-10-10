using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class LibAut : Entity
    {
        public LibAut()
        {
            Books = new HashSet<Book>();
            Authors = new HashSet<Author>();
        }
        public int IdBook { get; set; }
        public int IdAuthor { get; set; }
        public virtual ICollection<Book> Books { get; private set; }
        public virtual ICollection<Author> Authors { get; private set; }
    }
}
