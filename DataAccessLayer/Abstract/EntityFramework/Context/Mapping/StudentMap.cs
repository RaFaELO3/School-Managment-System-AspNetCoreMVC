using System;
using System.Collections.Generic;
using System.Text;
using Entity.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.Abstract.EntityFramework.Context.Mapping
{
    public class StudentMap : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {

            //Properties
            builder.HasKey(I => I.StudentID);
            builder.Property(I => I.StudentID).UseIdentityColumn();
            builder.Property(I => I.StudentName).HasMaxLength(100).IsRequired();
            builder.Property(I => I.StudentSurname).HasMaxLength(100).IsRequired();
            builder.Property(I => I.Email).HasMaxLength(100).IsRequired();
            builder.Property(I => I.Password).HasMaxLength(100).IsRequired();
            //Relations
            builder.HasOne(I => I.Group).WithMany(I => I.Students).HasForeignKey(I => I.StudentID);  
            builder.HasOne(I => I.Speciality).WithMany(I => I.Students).HasForeignKey(I => I.StudentID);
        }
    }
}
