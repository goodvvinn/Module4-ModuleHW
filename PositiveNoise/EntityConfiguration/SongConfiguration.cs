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
    public class SongConfiguration : IEntityTypeConfiguration<Song>
    {
        public void Configure(EntityTypeBuilder<Song> builder)
        {
            builder.ToTable("Song").HasKey(p => p.SongId);
            builder.Property(p => p.SongId).HasColumnName("SongId");
            builder.Property(p => p.Title).HasColumnName("Title").HasMaxLength(50);
            builder.Property(p => p.Duration).HasColumnName("Duration").HasColumnType("time").IsFixedLength();
            builder.Property(p => p.ReleaseDate).IsRequired().HasColumnType("date");
            builder.HasOne(d => d.Genre)
               .WithMany(c => c.Songs)
               .HasForeignKey(d => d.GenreId)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
