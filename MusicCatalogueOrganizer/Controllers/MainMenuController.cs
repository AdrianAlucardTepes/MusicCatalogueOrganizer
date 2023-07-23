using MusicCatalogueOrganizer.UserInterface;

namespace MusicCatalogueOrganizer.Controllers
{
    /// <summary>
    /// The MainMenuController class is responsible for managing the main menu of the application.
    /// </summary>
    public class MainMenuController
    {
        #region Private Fields
        // The user interface used to display menus.
        private readonly MenusUI _menusUI;
        // The user interface used to display information.
        private readonly InformativeUI _informativeUI;
        // The user interface used to display errors.
        private readonly ErrorsUI _errorsUI;
        // The controller used to display all songs.
        private readonly DisplayAllSongsController _displayAllSongsController;
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the MainMenuController class with the specified dependencies.
        /// </summary>
        /// <param name="menusUI">The user interface used to display menus.</param>
        /// <param name="informativeUI">The user interface used to display information.</param>
        /// <param name="errorsUI">The user interface used to display errors.</param>
        /// <param name="displayAllSongsController">The controller used to display all songs.</param>
        public MainMenuController(MenusUI menusUI, InformativeUI informativeUI, ErrorsUI errorsUI, DisplayAllSongsController displayAllSongsController)
        {
            _menusUI = menusUI;
            _errorsUI = errorsUI;
            _informativeUI = informativeUI;
            _displayAllSongsController = displayAllSongsController;
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Displays the main menu and handles user input.
        /// </summary>
        public void MainMenuManager()
        {
            while (true)
            {
                _menusUI.ShowMainMenu();
                var key = Console.ReadKey(true).Key;

                MainMenuOption? selectedOption = null;

                switch (key)
                {
                    case ConsoleKey.F1:
                        selectedOption = MainMenuOption.AddNewSong;
                        break;
                    case ConsoleKey.F2:
                        selectedOption = MainMenuOption.ManageLists;
                        break;
                    case ConsoleKey.F3:
                        selectedOption = MainMenuOption.EditSong;
                        break;
                    case ConsoleKey.F4:
                        selectedOption = MainMenuOption.DeleteSong;
                        break;
                    case ConsoleKey.F5:
                        selectedOption = MainMenuOption.DeleteAllSongs;
                        break;
                    case ConsoleKey.F6:
                        selectedOption = MainMenuOption.DisplayAllSongs;
                        break;
                    case ConsoleKey.F7:
                        selectedOption = MainMenuOption.SearchSongs;
                        break;
                    case ConsoleKey.F8:
                        selectedOption = MainMenuOption.Exit;
                        break;
                    default:
                        Console.Clear();
                        _errorsUI.InvalidInput();
                        break;
                }

                if (selectedOption.HasValue)
                {
                    switch (selectedOption.Value)
                    {
                        case MainMenuOption.AddNewSong:
                            // Handle adding a new song
                            break;
                        case MainMenuOption.ManageLists:
                            // Handle managing lists
                            break;
                        case MainMenuOption.EditSong:
                            // Handle editing a song
                            break;
                        case MainMenuOption.DeleteSong:
                            // Handle deleting a song
                            break;
                        case MainMenuOption.DeleteAllSongs:
                            // Handle deleting all songs
                            break;
                        case MainMenuOption.DisplayAllSongs:
                            Console.Clear();
                            _displayAllSongsController.DisplaySongsMenuManager();
                            break;
                        case MainMenuOption.SearchSongs:
                            // Handle searching for songs
                            break;
                        case MainMenuOption.Exit:
                            Console.Clear();
                            _informativeUI.FarewellMessage();
                            Environment.Exit(0);
                            return;
                    }
                }
            }
        }
        #endregion

        #region Private Enums
        /// <summary>
        /// Represents the different options in the main menu.
        /// </summary>
        private enum MainMenuOption
        {
            AddNewSong,
            ManageLists,
            EditSong,
            DeleteSong,
            DeleteAllSongs,
            DisplayAllSongs,
            SearchSongs,
            Exit
        }
        #endregion
    }
}