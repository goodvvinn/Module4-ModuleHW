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
    public class ArtistConfiguration : IEntityTypeConfiguration<Artist>
    {
        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.ToTable("Artist").HasKey(p => p.ArtistId);
            builder.Property(p => p.ArtistId).HasColumnName("ArtistId");
            builder.Property(p => p.Name).HasColumnName("Name").IsRequired().HasMaxLength(50);
            builder.Property(p => p.DateOfBirth).HasColumnName("DateOfBirth").IsRequired().HasColumnType("date");
            builder.Property(p => p.PhoneNumber).HasColumnName("PhoneNumber").HasMaxLength(13);
            builder.Property(p => p.Email).HasColumnName("Email").HasMaxLength(50);
            builder.Property(p => p.InstagramURL).HasColumnName("InstagramURL").HasMaxLength(50);
        }
    }
}
