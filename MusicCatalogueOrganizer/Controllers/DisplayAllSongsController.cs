using MusicCatalogueOrganizer.Data;
using MusicCatalogueOrganizer.Models;
using MusicCatalogueOrganizer.UserInterface;

namespace MusicCatalogueOrganizer.Controllers
{
    public class DisplayAllSongsController
    {
        #region Private Fields
        private readonly IMusicCatalogueRepository _musicCatalogueRepository;
        private readonly ErrorsUI _errorsUI;
        private readonly MenusUI _menusUI;
        private readonly InformativeUI _informativeUI;
        //private readonly MainMenuController _mainMenuController;
        #endregion

        #region Constructor
        public DisplayAllSongsController(IMusicCatalogueRepository musicCatalogueRepository, ErrorsUI errorsUI, MenusUI menusUI, InformativeUI informativeUI/*, MainMenuController mainMenuController*/)
        {
            _musicCatalogueRepository = musicCatalogueRepository;
            _errorsUI = errorsUI;
            _menusUI = menusUI;
            _informativeUI = informativeUI;
            //_mainMenuController = mainMenuController;

        }
        #endregion

        public void DisplaySongsMenuManager()
        {
            var songs = _musicCatalogueRepository.GetAllSongs();

            _menusUI.ShowSongsListMenu();
            _informativeUI.DisplayAllSongs(songs);

            while (true)
            {
                var key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.F1:
                        // Change the order of the songs by Creation Date
                        break;
                    case ConsoleKey.F2:
                        // Change the order of the songs by Song Name Alphabetical
                        break;
                    case ConsoleKey.F3:
                        // Change the order of the songs by Release Date
                        break;
                    case ConsoleKey.F4:
                        // Change the order of the songs by Rate
                        break;
                    case ConsoleKey.F5:
                        // Change the order of the songs by Genre Alphabetical
                        break;
                    case ConsoleKey.F6:
                        // Change the order of the songs by Album Alphabetical
                        break;
                    case ConsoleKey.F7:
                        // Change the order of the songs by Album Release Date
                        break;
                    case ConsoleKey.F8:
                        // Perform a manual search
                        break;
                    case ConsoleKey.F9:
                        Console.Clear();
                        //MainMenuController
                        return;
                    case ConsoleKey.F10:
                        Console.Clear();
                        _informativeUI.FarewellMessage();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        _errorsUI.InvalidInput();
                        _menusUI.ShowSongsListMenu();
                        _informativeUI.DisplayAllSongs(songs);
                        break;
                }
            }
        }

    }
}
