using ApiDotNet.Domain.Entities;
using ApiDotNet.Infra.Data.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiDotNet.Infra.Data.Maps
{
    public class ProductMap : BaseMapping<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            base.Configure(builder);
            builder.ToTable("produto");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("idproduto")
                .UseIdentityColumn();

            builder.Property(x => x.CodErp)
                .HasColumnName("coderp");

            builder.Property(x => x.Name)
              .HasColumnName("nome");

            builder.Property(x => x.Price)
              .HasColumnName("preco");

            builder.HasMany(x => x.Purchases)
                .WithOne(x => x.Product)
                .HasForeignKey(x => x.ProductId);
        }
    }
}