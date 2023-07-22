using MusicCatalogueOrganizer.Data;
using MusicCatalogueOrganizer.Models;

namespace MusicCatalogueOrganizer.UserInterface
{
    public class InformativeUI
    {
        #region Private Fields
        private readonly IMusicCatalogueRepository _musicCatalogueRepository;
        #endregion

        #region Constructor
        public InformativeUI(IMusicCatalogueRepository musicCatalogueRepository)
        {
            _musicCatalogueRepository = musicCatalogueRepository;
        }
        #endregion

        #region Public Methods
        public void DisplayTotalCountedSongs()
        {
            Console.WriteLine();

            var totalSongs = _musicCatalogueRepository.GetAllSongs().Count;
            var header = $"Total Available Songs: {totalSongs}";

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(header);
            Console.WriteLine(new string('-', header.Length));
            Console.ResetColor();

            Console.WriteLine();
        }

        public void DisplayAllSongs(List<Song> songs)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            var header = $"{"ID",-3} | {"Title",-20} | {"Artist",-20} | {"Album",-30} | {"Genre",-15} | {"Rate",-5} | {"Release Date",-15} | {"Creation Date",-15}";
            Console.WriteLine(header);
            Console.WriteLine(new string('=', header.Length));
            Console.ResetColor();

            int count = 0;
            foreach (var song in songs)
            {
                count++;
                var releaseDate = song.ReleaseDate.HasValue ? song.ReleaseDate.Value.ToString("yyyy/MM/dd") : "";
                var creationDate = song.CreationDate.ToString("yyyy/MM/dd");

                if (count % 2 == 0)
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                else
                    Console.BackgroundColor = ConsoleColor.Black;

                Console.WriteLine($"{song.Id,-3} | {song.Title,-20} | {song.Artist,-20} | {song.Album,-30} | {song.Genre,-15} | {song.Rate,-5} | {releaseDate,-15} | {creationDate,-15}");
                Console.ResetColor();
            }
        }
        #endregion
    }
}