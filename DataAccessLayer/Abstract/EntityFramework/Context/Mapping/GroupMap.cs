using Entity.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract.EntityFramework.Context.Mapping
{
    public class GroupMap : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            //Properties
            builder.HasKey(I => I.GroupID);
            builder.Property(I => I.GroupID).UseIdentityColumn();
            builder.Property(I => I.GroupName).HasMaxLength(100).IsRequired();

            //Relations
            builder.HasMany(I => I.Students).WithOne(I => I.Group).HasForeignKey(I => I.GroupID);
      
        }
    }
}
