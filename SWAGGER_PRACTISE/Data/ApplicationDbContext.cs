using Microsoft.EntityFrameworkCore;
using SWAGGER_PRACTISE.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWAGGER_PRACTISE.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options):base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}
