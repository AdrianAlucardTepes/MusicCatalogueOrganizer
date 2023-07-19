using MusicCatalogueOrganizer.Data;

namespace MusicCatalogueOrganizer.Controllers
{
    public class MainMenuController
    {
        private readonly IMusicCatalogueRepository _repository;

        public MainMenuController(IMusicCatalogueRepository repository)
        {
            _repository = repository;
        }

        public void HandleInput(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.F1:
                    AddNewSong();
                    break;
                case ConsoleKey.F2:
                    EditSong();
                    break;
                case ConsoleKey.F3:
                    DeleteSong();
                    break;
                case ConsoleKey.F4:
                    DisplaySongs();
                    break;
                case ConsoleKey.F5:
                    SearchForSongs();
                    break;
                case ConsoleKey.F6:
                    // Exit
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }

        private void AddNewSong()
        {
            // ...
        }

        private void EditSong()
        {
            // ...
        }

        private void DeleteSong()
        {
            // ...
        }

        private void DisplaySongs()
        {
            Console.WriteLine("Display Songs");
            Console.WriteLine();

            var songs = _repository.GetAllSongs();

            if (songs.Count == 0)
            {
                Console.WriteLine("No songs found.");
                return;
            }

            Console.WriteLine("{0,-5} {1,-20} {2,-20} {3,-20} {4,-10} {5,-5} {6,-10} {7,-10}", "Id", "Title", "Artist", "Album", "Genre", "Rate", "Release Date", "Creation Date");
            Console.WriteLine(new string('-', 90));

            foreach (var song in songs)
            {
                Console.WriteLine("{0,-5} {1,-20} {2,-20} {3,-20} {4,-10} {5,-5} {6,-15} {7,-20}",
                                  song.Id,
                                  song.Title,
                                  song.Artist,
                                  song.Album,
                                  song.Genre,
                                  song.Rate,
                                  song.ReleaseDate?.ToString("yyyy-MM-dd"),
                                  song.CreationDate.ToString("yyyy-MM-dd HH:mm:ss"));
            }
        }

        private void SearchForSongs()
        {
            // ...
        }
    }
}