using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Author : Entity
    {
        public Author()
        {
            this.Books = new HashSet<Book>();
        }
        public string Name { get; set; }
        public string Nationality { get; set; }
        public virtual ICollection<Book> Books { get; private set; }
    }
}
