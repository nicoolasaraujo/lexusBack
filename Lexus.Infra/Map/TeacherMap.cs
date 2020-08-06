using Lexus.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lexus.Infra.Map
{
    public class TeacherMap : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.Property(x => x.FirstName)
                .HasColumnType("VARCHAR(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.LastName)
              .HasColumnType("VARCHAR(100)")
              .HasMaxLength(100)
              .IsRequired();

            builder.Property(x => x.EmailAddres)
                .HasColumnType("VARCHAR(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.PhotoPath)
                  .HasColumnType("VARCHAR(200)")
                  .HasMaxLength(200)
                  .IsRequired();
        }
    }
}
