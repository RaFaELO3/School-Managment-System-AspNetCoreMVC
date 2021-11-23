using Entity.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract.EntityFramework.Context.Mapping
{
    public class TeacherMap : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            //Properties
            builder.HasKey(I => I.TeacherID);
            builder.Property(I => I.TeacherID).UseIdentityColumn();
            builder.Property(I => I.TeacherName).HasMaxLength(100).IsRequired();
            builder.Property(I => I.TeacherSurname).HasMaxLength(100).IsRequired();
            builder.Property(I => I.Email).HasMaxLength(100).IsRequired();
            builder.Property(I => I.Password).HasMaxLength(100).IsRequired();

            //Relations
            builder.HasOne(I => I.Subject).WithMany(I => I.Teachers).HasForeignKey(I => I.TeacherID);
            builder.HasOne(I => I.Department).WithMany(I => I.Teachers).HasForeignKey(I => I.TeacherID);
        }
    }
}
    