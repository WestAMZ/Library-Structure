using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    class Author : Entity
    {
        public string Name { get; set; }
        public string Nationality { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
