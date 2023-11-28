using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace jwtapi.Models{
    public class AppdContext:DbContext{
        public AppdContext(DbContextOptions<AppdContext> options):base(options)
        {

        }
        public virtual DbSet<User
    }
}