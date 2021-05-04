using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PositiveNoise.Entity;

namespace PositiveNoise
{
    public class DataOperations
    {
        private ApplicationContext _context;
        public DataOperations(ApplicationContext context)
        {
            _context = context;
        }

        public void AddGenreEntity()
        {
            Genre rock = new ()
            {
                Title = "Rock"
            };
            Genre metall = new ()
            {
                Title = "Metall"
            };
            Genre pop = new ()
            {
                Title = "Pop"
            };
            Genre classic = new ()
            {
                Title = "Classic"
            };
            Genre jazz = new ()
            {
                Title = "Jazz"
            };
            _context.Genres.AddRange(rock, metall, pop, classic, jazz);
            _context.SaveChanges();
        }

        public void AddSongEntity()
        {
            var genre = _context.Genres.First(w => w.GenreId == 1);
            var genre2 = _context.Genres.First(w => w.GenreId == 2);
            var genre3 = _context.Genres.First(w => w.GenreId == 3);
            var genre4 = _context.Genres.First(w => w.GenreId == 4);
            var genre5 = _context.Genres.First(w => w.GenreId == 5);
            Song soundOfSilence = new ()
            {
                Title = "Sound of silence",
                Duration = new TimeSpan(00, 03, 17),
                ReleaseDate = new DateTime(2007, 03, 04),
                GenreId = genre.GenreId,
            };
            Song wrongSideOfHaven = new ()
            {
                Title = "Wrong Side Of Haven",
                Duration = new TimeSpan(00, 04, 12),
                ReleaseDate = new DateTime(2005, 03, 04),
                GenreId = genre2.GenreId,
            };
            Song piratesOfCaribian = new ()
            {
                Title = "Pirates Of Caribian",
                Duration = new TimeSpan(00, 04, 11),
                ReleaseDate = new DateTime(2015, 03, 04),
                GenreId = genre4.GenreId,
            };
            Song enjoyTheRide = new ()
            {
                Title = "Enjoy The Ride",
                Duration = new TimeSpan(00, 05, 12),
                ReleaseDate = new DateTime(2016, 03, 04),
                GenreId = genre3.GenreId,
            };
            Song summerTime = new ()
            {
                Title = "SummerTime",
                Duration = new TimeSpan(00, 04, 17),
                ReleaseDate = new DateTime(1957, 03, 04),
                GenreId = genre5.GenreId,
            };
            soundOfSilence.Artists.Add(_context.Artists.First(a => a.ArtistId == 1));
            wrongSideOfHaven.Artists.Add(_context.Artists.First(a => a.ArtistId == 2));
            piratesOfCaribian.Artists.Add(_context.Artists.First(a => a.ArtistId == 3));
            enjoyTheRide.Artists.Add(_context.Artists.First(a => a.ArtistId == 4));
            summerTime.Artists.Add(_context.Artists.First(a => a.ArtistId == 5));
            _context.Songs.AddRange(soundOfSilence, wrongSideOfHaven, piratesOfCaribian, enjoyTheRide, summerTime);
            _context.SaveChanges();
        }

        public void AddArtistEntity()
        {
            Artist disturbed = new ()
            {
                Name = "Disturbed",
                DateOfBirth = new DateTime(1994, 01, 01),
                PhoneNumber = 9987654,
                Email = "disturbed@world.com",
                InstagramURL = "www.instagram.com/disturbed/?hl=ru",
            };
            Artist fiveFingerDeadPunch = new ()
            {
                Name = "FiveFingerDeadPunch",
                DateOfBirth = new DateTime(2005, 01, 01),
                PhoneNumber = 9987654,
                Email = "fiveFingerDeadPunch@world.com",
                InstagramURL = "www.instagram.com/5fdp/?hl=ru",
            };
            Artist epica = new ()
            {
                Name = "Epica",
                DateOfBirth = new DateTime(2003, 01, 01),
                PhoneNumber = 9987654,
                Email = "epica@world.com",
                InstagramURL = "www.instagram.com/epicaofficial/",
            };
            Artist morcheeba = new ()
            {
                Name = "Morcheeba",
                DateOfBirth = new DateTime(2003, 01, 01),
                PhoneNumber = 9987654,
                Email = "morcheeba@world.com",
                InstagramURL = "www.instagram.com/morcheebaband/?hl=ru",
            };
            Artist ninaSimone = new ()
            {
                Name = "NinaSimone",
                DateOfBirth = new DateTime(1933, 01, 02),
                PhoneNumber = 9987654,
                Email = "ninaSimone@world.com",
                InstagramURL = "www.instagram.com/ninasimone/",
            };
            _context.Artists.AddRange(disturbed, fiveFingerDeadPunch, epica, morcheeba, ninaSimone);
            _context.SaveChanges();
        }
    }
}
