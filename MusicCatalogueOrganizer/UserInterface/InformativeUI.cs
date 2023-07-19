using MusicCatalogueOrganizer.Data;

namespace MusicCatalogueOrganizer.UserInterface
{
    public class InformativeUI
    {
        private readonly IMusicCatalogueRepository _musicCatalogueRepository;

        public InformativeUI(IMusicCatalogueRepository musicCatalogueRepository)
        {
            _musicCatalogueRepository = musicCatalogueRepository;
        }

        public void ShowTotalSongs()
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
    }
}
}