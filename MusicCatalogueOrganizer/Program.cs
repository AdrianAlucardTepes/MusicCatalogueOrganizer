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
            var informativeUI = new InformativeUI(musicCatalogueRepository);
            var menusUI = new MenusUI(informativeUI);
            var errorsUI = new ErrorsUI();
            var dataController = new DataController(musicCatalogueRepository, errorsUI, informativeUI);
            var displayAllSongsController = new DisplayAllSongsController(musicCatalogueRepository, errorsUI, menusUI, informativeUI);
            var mainMenuController = new MainMenuController(menusUI, informativeUI, errorsUI, displayAllSongsController, dataController);

            AddTemporaryData(musicCatalogueRepository);

            mainMenuController.MainMenuManager();
        }

        #region Private Methods
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
                Rate = 4,
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

            repository.AddSong(new Song
            {
                Title = "Imagine",
                Artist = "John Lennon",
                Album = "Imagine",
                Genre = "Rock",
                Rate = 4,
                ReleaseDate = new DateTime(1971, 9, 9),
                CreationDate = DateTime.Now
            });

            repository.AddSong(new Song
            {
                Title = "What's Going On",
                Artist = "Marvin Gaye",
                Album = "What's Going On",
                Genre = "Soul",
                Rate = 3,
                ReleaseDate = new DateTime(1971, 5, 21),
                CreationDate = DateTime.Now
            });

            repository.AddSong(new Song
            {
                Title = "Superstition",
                Artist = "Stevie Wonder",
                Album = "Talking Book",
                Genre = "Funk",
                Rate = 2,
                ReleaseDate = new DateTime(1972, 10, 24),
                CreationDate = DateTime.Now
            });
        }
        #endregion
    }
}