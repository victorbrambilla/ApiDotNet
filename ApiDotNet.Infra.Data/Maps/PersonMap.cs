using ApiDotNet.Domain.Entities;
using ApiDotNet.Infra.Data.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiDotNet.Infra.Data.Maps
{
    public class PersonMap : BaseMapping<Person>
    {
        public override void Configure(EntityTypeBuilder<Person> builder)
        {
            base.Configure(builder);
            builder.ToTable("pessoa");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .HasColumnName("idpessoa")
                .UseIdentityColumn();

            builder.Property(c => c.Name)
                .HasColumnName("nome");

            builder.Property(c => c.Document)
                .HasColumnName("documento");

            builder.Property(c => c.Phone)
                .HasColumnName("celular");

            builder.Property(c => c.UserId)
                .HasColumnName("idusuario");

            builder.HasMany(c => c.Purchases)
                .WithOne(c => c.Person)
                .HasForeignKey(c => c.PersonId);

            builder.HasOne(c => c.User)
              .WithOne(c => c.Person)
              .HasForeignKey<User>(c => c.PersonId);
        }
    }
}