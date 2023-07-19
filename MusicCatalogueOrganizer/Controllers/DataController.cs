using MusicCatalogueOrganizer.Data;
using MusicCatalogueOrganizer.Models;
using MusicCatalogueOrganizer.UserInterface;

namespace MusicCatalogueOrganizer.Controllers
{
    public class DataController
    {
        private readonly IMusicCatalogueRepository _musicCatalogueRepository;
        private readonly ErrorsUI _errorsUI;
        private readonly MenusUI _menusUI;

        public DataController(IMusicCatalogueRepository musicCatalogueRepository, ErrorsUI errorsUI, MenusUI menusUI)
        {
            _musicCatalogueRepository = musicCatalogueRepository;
            _errorsUI = errorsUI;
            _menusUI = menusUI;
        }

        public void DisplaySongs()
        {
            var songs = _musicCatalogueRepository.GetAllSongs();

            if (songs.Count == 0)
            {
                _errorsUI.NoSongsFound();
                return;
            }

            _menusUI.ShowSongsListMenu();

            Console.WriteLine("{0,-5} {1,-30} {2,-30} {3,-20} {4,-20} {5,-10} {6,-10} {7,-10}", "ID", "Title", "Artist", "Album", "Genre", "Rate", "Release Date", "Creation Date");
            Console.WriteLine(new string('-', 145));

            foreach (var song in songs)
            {
                var releaseDate = song.ReleaseDate.HasValue ? song.ReleaseDate.Value.ToShortDateString() : "";
                var creationDate = song.CreationDate.ToShortDateString();

                Console.WriteLine("{0,-5} {1,-30} {2,-30} {3,-20} {4,-20} {5,-10} {6,-10} {7,-10}",
                                  song.Id,
                                  song.Title,
                                  song.Artist,
                                  song.Album,
                                  song.Genre,
                                  song.Rate,
                                  releaseDate,
                                  creationDate);
            }
        }
    }
}