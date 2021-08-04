using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace Admin.Models
{
    public class FacultyRepo :DbContext
    {
        public FacultyRepo(DbContextOptions<FacultyRepo>Options) : base(Options) { }
             public  DbSet<Faculty>Faculty{ get; set; }
        public DbSet<FacultySkill> FacultySkill { get; set; }
        public DbSet<Module>Module { get; set; }
        public DbSet<Batch> Batch { get; set; }
        public DbSet<Batchupdate> Batchupdate { get; set; }
         public DbSet<Report> Report { get; set; }
        public DbSet<Award> Award { get; set; }
        public DbSet<Credit> Credit { get; set; }
        public DbSet<Login> Login { get; set; }
    }
}
