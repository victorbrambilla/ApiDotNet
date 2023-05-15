using ApiDotNet.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDotNet.Infra.Data.Maps
{
    public class PersonMap : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("Pessoa");

            builder.HasKey(c => c.Id);

            builder.Property(c=> c.Id)
                .HasColumnName("Idpessoa")
                .UseIdentityColumn();

            builder.Property(c => c.Name)
                .HasColumnName("Nome");

            builder.Property(c => c.Document)
                .HasColumnName("Documento");

            builder.Property(c => c.Phone)
                .HasColumnName("Celular");

            builder.HasMany(c => c.Purchases)
                .WithOne(c => c.Person)
                .HasForeignKey(c => c.PersonId);

        }
    }
}
