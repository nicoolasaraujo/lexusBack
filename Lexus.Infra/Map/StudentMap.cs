using Lexus.Core.Enums;
using Lexus.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lexus.Infra.Map
{
    public class StudentMap : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(x => x.FirstName)
                .HasColumnType("VARCHAR(100)")
                .HasMaxLength(100)
                .IsRequired();

            builder.Property(x => x.LastName)
              .HasColumnType("VARCHAR(100)")
              .HasMaxLength(100)
              .IsRequired();

            var userId1 = Guid.Parse("29ebc350-c831-4ec3-8eca-077f995b47ff");
            var userStudent = new Student() { StudentId = userId1, FirstName = "Joãozinho", LastName = "Da Silva", BirthDay = DateTime.Now, Gender = EnGender.MALE };
            builder.HasData(userStudent);
        }
    }
}
