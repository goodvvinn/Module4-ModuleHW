using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PositiveNoise
{
    public class Queries
    {
        private readonly ApplicationContext _context;

        public Queries(ApplicationContext context)
        {
            _context = context;
        }

        public async Task Task1Async()
        {
            var compositions = await _context.Songs
                .Select(x => new
                {
                    x.Title,
                    Name = string.Join(string.Empty, x.Artists.Select(a => a.Name)),
                    Genre = x.Genre.Title
                }).ToListAsync();
            Console.WriteLine($"\t\n------------------Task1--------------");
            foreach (var item in compositions)
            {
                Console.WriteLine($"|The Song:{item.Title}|- |Genre:{item.Genre}|- |Artist:{item.Name}|");
            }

            Console.WriteLine("\t\n\n\n");
        }

        public async Task Task2Async()
        {
            var genreCount = await _context.Genres
                    .GroupBy(u => u.Title)
                    .Select(g => new
                    {
                        g.Key,
                        Count = g.Count()
                    }).ToListAsync();
            Console.WriteLine($"\t\n------------------Task2--------------");
            foreach (var group in genreCount)
            {
                Console.WriteLine($"Genre:{group.Key} - has {group.Count} song(s)");
            }

            Console.WriteLine("\t\n\n\n");
        }

        public async Task Task3Async()
        {
            var maxDate = await _context.Artists.MaxAsync(m => m.DateOfBirth);
            var songsWithYoungerArtist = await _context.Songs
                .Where(w => w.ReleaseDate < maxDate).ToListAsync();
            Console.WriteLine($"\t\n------------------Task3--------------");
            foreach (var item in songsWithYoungerArtist)
            {
                Console.WriteLine($"Songs that was written before the youngest artist in this DB was born are: {item.Title}");
            }

            Console.WriteLine("\t\n\n\n");
        }
    }
}
