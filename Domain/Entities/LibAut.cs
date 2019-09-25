using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    class LibAut : Entity
    {
        public int IdBook { get; set; }
        public int IdAuthor { get; set; }
        public virtual ICollection<Book> Books { get; set; }
        public virtual ICollection<Author> Authors { get; set; }
    }
}
