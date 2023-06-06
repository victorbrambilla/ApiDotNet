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
    public class PermissionMap : IEntityTypeConfiguration<Permission>
    {
        public void Configure(EntityTypeBuilder<Permission> builder)
        {
            builder.ToTable("permissao");
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .HasColumnName("idpermissao")
                .UseIdentityColumn();

            builder.Property(c => c.VisualName)
                .HasColumnName("nomevisual");

            builder.Property(c => c.PermissionName)
                .HasColumnName("nomepermissao");

            builder.HasMany(c => c.UserPermissions)
                .WithOne(c => c.Permission)
                .HasForeignKey(c => c.PermissionId);
        }
    }
}