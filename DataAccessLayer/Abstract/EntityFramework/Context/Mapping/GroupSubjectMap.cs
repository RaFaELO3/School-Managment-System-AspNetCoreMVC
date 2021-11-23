using Entity.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract.EntityFramework.Context.Mapping
{
    public class GroupSubjectMap : IEntityTypeConfiguration<GroupSubject>
    {
        public void Configure(EntityTypeBuilder<GroupSubject> builder)
        {
            //Properties
            builder.HasKey(I => new { I.GroupID, I.SubjectID });

            //Relations
            builder.HasOne(I => I.Subject).WithMany(I => I.groupSubject).HasForeignKey(I => I.SubjectID);
            builder.HasOne(I => I.Group).WithMany(I => I.groupSubject).HasForeignKey(I => I.GroupID);
        }
    }

}
