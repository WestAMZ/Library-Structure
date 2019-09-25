using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    class Book : Entity
    {
        public string Editorial { get; set; }
        public string Area { get; set; }
    }
}
