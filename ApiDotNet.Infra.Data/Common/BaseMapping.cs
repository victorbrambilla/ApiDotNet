using ApiDotNet.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDotNet.Infra.Data.Common
{
    public class BaseMapping<T> : IEntityTypeConfiguration<T> where T : BaseEntity
    {
        public virtual void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<T> builder)
        {
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.CreatedAt).HasDefaultValue(DateTime.Now);
            builder.Property(x => x.UpdatedAt).HasDefaultValue(null);
            builder.Property(x => x.DeletedAt).HasDefaultValue(null);
        }
    }
}