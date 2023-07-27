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

                if (count % 2 == 0) Console.BackgroundColor = ConsoleColor.DarkGray;
                else Console.BackgroundColor = ConsoleColor.Black;

                Console.WriteLine($"{song.Id,-3} | {song.Title,-20} | {song.Artist,-20} | {song.Album,-30} | {song.Genre,-15} | {song.Rate,-5} | {releaseDate,-15} | {creationDate,-15}");
                Console.ResetColor();
            }
        }

        public void FarewellMessage()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Farewell & Thank you for using my application :)");
            Console.ResetColor();
        }

        public void DisplayCreationDateSortOrder(bool isSortedAscending)
        {
            DisplaySortOrder("Creation Date", isSortedAscending ? "oldest" : "newest", isSortedAscending ? "newest" : "oldest");
        }

        public void DisplaySongNameAlphabeticalSortOrder(bool isSortedAscending)
        {
            DisplaySortOrder("Title", isSortedAscending ? "ascending" : "descending");
        }

        public void DisplayReleaseDateSortOrder(bool isSortedAscending)
        {
            DisplaySortOrder("Release Date", isSortedAscending ? "oldest" : "newest", isSortedAscending ? "newest" : "oldest");
        }

        public void DisplayRateSortOrder(bool isSortedAscending)
        {
            DisplaySortOrder("Rate", isSortedAscending ? "lowest" : "highest", isSortedAscending ? "highest" : "lowest");
        }

        public void DisplayGenreAlphabeticalSortOrder(bool isSortedAscending)
        {
            DisplaySortOrder("Genre", isSortedAscending ? "ascending" : "descending");
        }
        #endregion

        #region Private Methods
        private void DisplaySortOrder(string criteria, string order, string oppositeOrder = null)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;

            string message;
            if (oppositeOrder != null)
                message = $"Sorted by {criteria} from: {order} to {oppositeOrder}.";
            else
                message = $"Sorted by {criteria} in: {order} order.";

            Console.WriteLine(new string('~', message.Length));
            Console.WriteLine(message);
            Console.WriteLine(new string('~', message.Length));

            Console.ResetColor();
            Console.WriteLine();
        }

        #endregion
    }
}