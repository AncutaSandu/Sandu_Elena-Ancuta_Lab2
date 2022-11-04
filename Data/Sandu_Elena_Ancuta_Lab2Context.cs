using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Sandu_Elena_Ancuta_Lab2.Models;

namespace Sandu_Elena_Ancuta_Lab2.Data
{
    public class Sandu_Elena_Ancuta_Lab2Context : DbContext
    {
        public Sandu_Elena_Ancuta_Lab2Context (DbContextOptions<Sandu_Elena_Ancuta_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Sandu_Elena_Ancuta_Lab2.Models.Book> Book { get; set; } = default!;
    }
}
