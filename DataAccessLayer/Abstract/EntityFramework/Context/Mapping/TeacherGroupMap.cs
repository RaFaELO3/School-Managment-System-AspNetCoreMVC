using Entity.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract.EntityFramework.Context.Mapping
{
    public class TeacherGroupMap : IEntityTypeConfiguration<TeacherGroup>
    {
        public void Configure(EntityTypeBuilder<TeacherGroup> builder)
        {
            //Properties
            builder.HasKey(I => new { I.GroupID, I.TeacherID });

            //Relations
            builder.HasOne(I => I.Teacher).WithMany(I => I.teacherGroup).HasForeignKey(I => I.TeacherID);
            builder.HasOne(I => I.Group).WithMany(I => I.teacherGroup).HasForeignKey(I => I.GroupID);
        }
    }
}
