using ApiDotNet.Domain.Entities;
using ApiDotNet.Infra.Data.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDotNet.Infra.Data.Maps
{
    public class UserPermissionMap : BaseMapping<UserPermission>
    {
        public override void Configure(EntityTypeBuilder<UserPermission> builder)
        {
            base.Configure(builder);
            builder.ToTable("permissaousuario");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .HasColumnName("idpermissaousuario")
                .UseIdentityColumn();

            builder.Property(c => c.UserId)
                .HasColumnName("idusuario");

            builder.Property(c => c.PermissionId)
                .HasColumnName("idpermissao");

            builder.HasOne(c => c.User)
                .WithMany(c => c.UserPermissions)
                .HasForeignKey(c => c.UserId);

            builder.HasOne(c => c.Permission)
                .WithMany(c => c.UserPermissions)
                .HasForeignKey(c => c.PermissionId);
        }
    }
}