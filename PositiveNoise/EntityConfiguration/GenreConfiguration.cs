using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PositiveNoise.Entity;

namespace PositiveNoise.EntityConfiguration
{
    public class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.ToTable("Genre").HasKey(p => p.GenreId);
            builder.Property(p => p.GenreId).HasColumnName("GenreId");
            builder.Property(p => p.Title).IsRequired().HasMaxLength(70);
        }
    }
}
