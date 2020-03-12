using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication_Core_mvc.Models;

namespace WebApplication_Core_mvc.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{ 
        //    base.OnModelCreating(modelBuilder);
        //}

        //protected override void OnModelCreating(DbModelBuilder modelBuilder) { 
        //    modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        //}
        public DbSet<Creation> Creations { get; set; }
        public DbSet<CreationLike> CreationLikes { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Class1> Class1s { get; set; }
        public DbSet<Class2> Class2s { get; set; }
        public DbSet<ViewModel1> ViewModel1 { get; set; }
        public DbSet<Consignment> Consignment { get; set; }
        public DbSet<ConsignmentLine> ConsignmentLine { get; set; }
        public DbSet<Position> Position { get; set; }
        public DbSet<TaskProjectList> TaskProjectList { get; set; }
        public DbSet<TaskTickets> TaskTickets { get; set; }
        public DbSet<TaskCreate> TaskCreate { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<TaskCreate>(eb =>
                {
                    eb.HasNoKey();
                });
        }
    }
}
