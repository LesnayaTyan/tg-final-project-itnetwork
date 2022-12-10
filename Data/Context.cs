using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalProjectInsurance_TG.Models;

namespace FinalProjectInsurance_TG.Data
{
    public class Context : DbContext
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Context (DbContextOptions<Context> options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
            : base(options)
        {
        }

        public DbSet<FinalProjectInsurance_TG.Models.Customer> Customer { get; set; } = default!;

        public DbSet<FinalProjectInsurance_TG.Models.Insurance> Insurance { get; set; }
    }
}
