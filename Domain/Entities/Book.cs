using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Book : Entity
    {
        public Book()
        {
            LibAut = new HashSet<LibAut>();
        }
        public string Editorial { get; set; }
        public string Area { get; set; }
        public virtual ICollection<LibAut> LibAut { get; private set; }
    }
}
