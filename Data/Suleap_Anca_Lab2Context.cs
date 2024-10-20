using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Suleap_Anca_Lab2.Models;

namespace Suleap_Anca_Lab2.Data
{
    public class Suleap_Anca_Lab2Context : DbContext
    {
        public Suleap_Anca_Lab2Context (DbContextOptions<Suleap_Anca_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Suleap_Anca_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Suleap_Anca_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Suleap_Anca_Lab2.Models.Author> Author { get; set; } = default!;
    }
}
