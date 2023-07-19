using MusicCatalogueOrganizer.Controllers;
using MusicCatalogueOrganizer.Data;
using MusicCatalogueOrganizer.Models;
using MusicCatalogueOrganizer.UserInterface;

namespace MusicCatalogueOrganizer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var musicCatalogueRepository = new MusicCatalogueRepository();
            var menusUI = new MenusUI();
            var errorsUI = new ErrorsUI();
            var dataController = new DataController(musicCatalogueRepository, errorsUI);

            var mainMenuController = new MainMenuController(musicCatalogueRepository, menusUI, errorsUI, dataController);
            
            mainMenuController.Run();
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