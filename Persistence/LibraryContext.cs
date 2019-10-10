using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;

namespace Persistence
{
    public class LibraryContext : DbContext 
    {
        public virtual DbSet<Author> Authors { get; set; }
    }
}
