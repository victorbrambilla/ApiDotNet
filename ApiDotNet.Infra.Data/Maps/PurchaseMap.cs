using ApiDotNet.Domain.Entities;
using ApiDotNet.Infra.Data.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiDotNet.Infra.Data.Maps
{
    public class PurchaseMap : BaseMapping<Purchase>
    {
        public override void Configure(EntityTypeBuilder<Purchase> builder)
        {
            base.Configure(builder);
            builder.ToTable("compra");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("idcompra")
                .UseIdentityColumn();

            builder.Property(x => x.PersonId)
                .HasColumnName("idpessoa")
                .UseIdentityColumn();

            builder.Property(x => x.ProductId)
                .HasColumnName("idproduto")
                .UseIdentityColumn();

            builder.Property(x => x.Date)
                .HasColumnType("date")
                .HasColumnName("datacompra");

            builder.HasOne(x => x.Person)
                .WithMany(x => x.Purchases);

            builder.HasOne(x => x.Product)
                .WithMany(x => x.Purchases);
        }
    }
}