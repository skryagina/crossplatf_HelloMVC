using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using skryagina_lr1.Models;

namespace skryagina_lr1.Data
{
    public class skryagina_lr1Context : DbContext
    {
        public skryagina_lr1Context (DbContextOptions<skryagina_lr1Context> options)
            : base(options)
        {
        }

        public DbSet<skryagina_lr1.Models.ExampleModel> ExampleModel { get; set; } = default!;
    }
}
