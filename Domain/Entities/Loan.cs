using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Loan : Entity
    {
        public int IdStudent { get; set; }
        public int IdBook { get; set; }
        public DateTime LoanDate { get; set; }
        public bool Returned { get; set; }
        public virtual Student Student { get; set; }
        public virtual Book Book { get; set; }
    }
}
