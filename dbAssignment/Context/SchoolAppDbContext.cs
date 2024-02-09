
using Microsoft.EntityFrameworkCore;
using SchoolApp2.Entities;
using SchooleApp2.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SchoolApp2.Context
{
    public class SchoolAppDbContext:DbContext
    {
        public SchoolAppDbContext()
        {
                
        }

        public SchoolAppDbContext(DbContextOptions<SchoolAppDbContext> options) : base(options)
        {


        }
        public DbSet<Student> Students { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<ClassRoom> ClassRooms { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\SchooleApp2\SchooleApp2\Data\SchoolDb2.mdf;Integrated Security=True");

        }
    }
}
