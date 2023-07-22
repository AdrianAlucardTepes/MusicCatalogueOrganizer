using MusicCatalogueOrganizer.Data;
using MusicCatalogueOrganizer.UserInterface;

namespace MusicCatalogueOrganizer.Controllers
{
    public class MainMenuController
    {
        #region Private Fields
        private readonly DataController _dataController;
        private readonly MenusUI _menusUI;
        private readonly InformativeUI _informativeUI;
        private readonly ErrorsUI _errorsUI;
        private readonly DisplayAllSongsController _displayAllSongsController;
        #endregion

        #region Constructor
        public MainMenuController(DataController dataController, MenusUI menusUI, InformativeUI informativeUI, ErrorsUI errorsUI, DisplayAllSongsController displayAllSongsController)
        {
            _dataController = dataController;
            _menusUI = menusUI;
            _errorsUI = errorsUI;
            _informativeUI = informativeUI;
            _displayAllSongsController = displayAllSongsController;
        }
        #endregion

        public void MainMenuManager()
        {
            while (true)
            {
                _menusUI.ShowMainMenu();
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
                        _displayAllSongsController.DisplaySongsMenuManager();
                        break;
                    case ConsoleKey.F5:
                        // Handle searching for songs
                        break;
                    case ConsoleKey.F6:
                        Console.Clear();
                        _informativeUI.FarewellMessage();
                        Environment.Exit(0);
                        return;
                    default:
                        Console.Clear();
                        _errorsUI.InvalidInput();
                        break;
                }
            }
        }
    }
}