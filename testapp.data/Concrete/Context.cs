using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using testapp.entity;
using testapp.entity.Concrete;

namespace testapp.data.Concrete
{
   public class Context: IdentityDbContext<AppUser,AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-TRMFE99;database=TestDB;integrated security=true;");
        }
        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     base.OnModelCreating(modelBuilder);
        //     modelBuilder.Entity<GKandGY>()
        //                  .HasKey(t => new{t.GKLessonId,t.GYLessonId});
        //     modelBuilder.Entity<GKandGY>()
        //                  .HasOne(gk => gk.GKLessons)
        //                  .WithMany(gk => gk.GKandGYs)
        //                  .HasForeignKey(gk => gk.GKLessonId);
                         

        //     modelBuilder.Entity<GKandGY>()
        //                  .HasOne(gk => gk.GYLessons)
        //                  .WithMany(gk => gk.GKandGYs)
        //                  .HasForeignKey(gk => gk.GYLessonId);                                
        // }

       
        public DbSet<Test>? Tests {get; set;}
        public DbSet<Lesson>? Lessons {get; set;}
        public DbSet<GKLesson>? GKLessons {get; set;}
        public DbSet<GYLesson>? GYLessons {get; set;}
        public DbSet<KpssResult>? KpssResults {get; set;}
       
    }      
    
}