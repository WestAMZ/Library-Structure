using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    class Entity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public Entity()
        {
            CreatedDate = DateTime.Now;
        }
    }
}
