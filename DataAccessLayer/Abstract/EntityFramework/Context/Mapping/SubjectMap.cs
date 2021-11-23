using Entity.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract.EntityFramework.Context.Mapping
{
    public class SubjectMap : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> builder)
        {
            //Properties
            builder.HasKey(I => I.SubjectID);
            builder.Property(I => I.SubjectID).UseIdentityColumn();
            builder.Property(I => I.SubjectName).HasMaxLength(100).IsRequired();

            //Relations
            builder.HasMany(I => I.Teachers).WithOne(I => I.Subject).HasForeignKey(I => I.SubjectID);
        }
    }
}
