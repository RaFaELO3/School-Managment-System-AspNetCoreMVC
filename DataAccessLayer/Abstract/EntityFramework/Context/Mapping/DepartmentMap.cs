using Entity.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract.EntityFramework.Context.Mapping
{
    class DepartmentMap : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            //Properties
            builder.HasKey(I => I.DepartmentID);
            builder.Property(I => I.DepartmentID).UseIdentityColumn();
            builder.Property(I => I.DepartmentName).HasMaxLength(100).IsRequired();

            //Relations
            builder.HasMany(I => I.Teachers).WithOne(I => I.Department).HasForeignKey(I => I.DepartmentID);
        }
    }
}
