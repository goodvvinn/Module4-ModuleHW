using System;
using System.Threading.Tasks;
using PositiveNoise;

namespace T
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            await using var context = new SampleContextFactory().CreateDbContext(args);

            // new DataOperations(context).AddArtistEntity();
            // new DataOperations(context).AddGenreEntity();
            // DataOperations(context).AddSongEntity();
            await new Queries(context).Task1Async();
            await new Queries(context).Task2Async();
            await new Queries(context).Task3Async();
        }
    }
}
