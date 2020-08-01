using Lexus.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lexus.Infra.Map
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.Id)
                .HasColumnType("VARCHAR(36)")
                .HasMaxLength(36)
                .IsRequired();

            builder.Property(x => x.Username)
                .HasColumnType("VARCHAR(50)")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.Password)
                .HasColumnType("VARCHAR(20)")
                .HasMaxLength(20)
                .IsRequired();

            builder.HasIndex(x => x.Username)
                .HasName("User_Unique")
                .IsUnique();

            builder.HasOne(t => t.Teacher).WithOne(u => u.User).HasForeignKey<Teacher>(x => x.TeacherId);

            builder.HasOne(t => t.Student).WithOne(u => u.User).HasForeignKey<Student>(x => x.StudentId);

            this.FillData(builder);
        }

        private void FillData(EntityTypeBuilder<User> builder)
        {
            builder.HasData(new User(Guid.NewGuid(), "nicoolas", "secretpass"));
        }

    }
}
