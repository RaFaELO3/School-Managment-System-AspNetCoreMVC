using DataAccessLayer.Abstract.EntityFramework.Context.Mapping;
using Entity.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract.EntityFramework.Context
{
    public class StoreContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=DESKTOP-A160AEA;
                                        database=SchoolManagmentSystemMVC;
                                        Trusted_Connection=true;"
                                       ); 
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentMap());
            modelBuilder.ApplyConfiguration(new TeacherMap()); 
            modelBuilder.ApplyConfiguration(new DepartmentMap());
            modelBuilder.ApplyConfiguration(new GroupMap());
            modelBuilder.ApplyConfiguration(new SubjectMap());
            modelBuilder.ApplyConfiguration(new SpecialityMap()); 
            modelBuilder.ApplyConfiguration(new TeacherGroupMap());
            modelBuilder.ApplyConfiguration(new GroupSubjectMap());
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Speciality> Specialities { get; set; }
    }
}

 

