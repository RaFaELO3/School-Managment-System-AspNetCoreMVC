using Entity.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract.EntityFramework.Context.Mapping
{
    public class SpecialityMap : IEntityTypeConfiguration<Speciality>
    {
        public void Configure(EntityTypeBuilder<Speciality> builder)
        {
            //Properties
            builder.HasKey(I => I.SpecialityID);
            builder.Property(I => I.SpecialityID).UseIdentityColumn();
            builder.Property(I => I.SpecialityName).HasMaxLength(100).IsRequired();

            //Relations
            builder.HasMany(I => I.Students).WithOne(I => I.Speciality).HasForeignKey(I => I.SpecialityID);
        }
    }
}
