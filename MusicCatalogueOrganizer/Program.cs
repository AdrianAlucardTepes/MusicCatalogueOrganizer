using MusicCatalogueOrganizer.Data;
using MusicCatalogueOrganizer.Models;
using MusicCatalogueOrganizer.UserInterface;

namespace MusicCatalogueOrganizer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var repository = new MusicCatalogueRepository();

            // Add some temporary data
            AddTemporaryData(repository);

            var menusUI = new MenusUI(repository);
            menusUI.ShowMainMenu();
        }

        private static void AddTemporaryData(IMusicCatalogueRepository repository)
        {
            repository.AddSong(new Song
            {
                Title = "Bohemian Rhapsody",
                Artist = "Queen",
                Album = "A Night at the Opera",
                Genre = "Rock",
                Rate = 5,
                ReleaseDate = new DateTime(1975, 10, 31),
                CreationDate = DateTime.Now
            });

            repository.AddSong(new Song
            {
                Title = "Stairway to Heaven",
                Artist = "Led Zeppelin",
                Album = "Led Zeppelin IV",
                Genre = "Rock",
                Rate = 5,
                ReleaseDate = new DateTime(1971, 11, 8),
                CreationDate = DateTime.Now
            });

            repository.AddSong(new Song
            {
                Title = "Hotel California",
                Artist = "Eagles",
                Album = "Hotel California",
                Genre = "Rock",
                Rate = 5,
                ReleaseDate = new DateTime(1976, 12, 8),
                CreationDate = DateTime.Now
            });
        }
    }
}