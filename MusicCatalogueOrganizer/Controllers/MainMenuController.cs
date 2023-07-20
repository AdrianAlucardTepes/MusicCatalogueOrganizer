using MusicCatalogueOrganizer.Data;
using MusicCatalogueOrganizer.UserInterface;

namespace MusicCatalogueOrganizer.Controllers
{
    public class MainMenuController
    {
        private readonly IMusicCatalogueRepository _musicCatalogueRepository;
        private readonly MenusUI _menusUI;
        private readonly ErrorsUI _errorsUI;
        private readonly DataController _dataController;

        public MainMenuController(IMusicCatalogueRepository musicCatalogueRepository, MenusUI menusUI, ErrorsUI errorsUI, DataController dataController)
        {
            _musicCatalogueRepository = musicCatalogueRepository;
            _menusUI = menusUI;
            _errorsUI = errorsUI;
            _dataController = dataController;
        }

        public void CentralRun()
        {
            _menusUI.ShowMainMenu();

            while (true)
            {
                var key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.F1:
                        // Handle adding a new song
                        break;
                    case ConsoleKey.F2:
                        // Handle editing a song
                        break;
                    case ConsoleKey.F3:
                        // Handle deleting a song
                        break;
                    case ConsoleKey.F4:
                        Console.Clear();
                        _dataController.DisplaySongs();
                        break;
                    case ConsoleKey.F5:
                        // Handle searching for songs
                        break;
                    case ConsoleKey.F6:
                        // Exit the application
                        return;
                    default:
                        Console.Clear();
                        _errorsUI.InvalidInput();
                        _menusUI.ShowMainMenu();
                        break;
                }
            }
        }
    }
}