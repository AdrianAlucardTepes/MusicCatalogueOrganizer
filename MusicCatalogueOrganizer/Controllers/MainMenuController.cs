using MusicCatalogueOrganizer.UserInterface;

namespace MusicCatalogueOrganizer.Controllers
{
    /// <summary>
    /// The MainMenuController class is responsible for managing the main menu of the application.
    /// </summary>
    public class MainMenuController
    {
        #region Private Fields
        // Dependencies
        private readonly MenusUI _menusUI;
        private readonly InformativeUI _informativeUI;
        private readonly ErrorsUI _errorsUI;
        private readonly DisplayAllSongsController _displayAllSongsController;
        private readonly DataController _dataController;
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the MainMenuController class with the specified dependencies.
        /// </summary>
        /// <param name="menusUI">The MenusUI instance to use for displaying menus.</param>
        /// <param name="informativeUI">The InformativeUI instance to use for displaying informative messages.</param>
        /// <param name="errorsUI">The ErrorsUI instance to use for displaying error messages.</param>
        /// <param name="displayAllSongsController">The DisplayAllSongsController instance to use for managing the display of all songs.</param>
        public MainMenuController(MenusUI menusUI, InformativeUI informativeUI, ErrorsUI errorsUI, DisplayAllSongsController displayAllSongsController, DataController dataController)
        {
            _menusUI = menusUI;
            _errorsUI = errorsUI;
            _informativeUI = informativeUI;
            _displayAllSongsController = displayAllSongsController;
            _dataController = dataController;
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Displays the main menu to the user and handles user input.
        /// </summary>
        public void MainMenuManager()
        {
            while (true)
            {
                // Show the main menu
                _menusUI.ShowMainMenu();

                // Get the user's input
                var key = Console.ReadKey(true).Key;

                // Determine which option the user selected
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

                // Handle the user's selection
                if (selectedOption.HasValue)
                    HandleSelectedOption(selectedOption.Value);
            }
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Handles the user's selection in the main menu.
        /// </summary>
        /// <param name="selectedOption">The selected option.</param>
        private void HandleSelectedOption(MainMenuOption selectedOption)
        {
            switch (selectedOption)
            {
                case MainMenuOption.AddNewSong:
                    Console.Clear();
                    _errorsUI.FeatureNotImplemented();
                    break;
                case MainMenuOption.ManageLists:
                    Console.Clear();
                    _errorsUI.FeatureNotImplemented();
                    break;
                case MainMenuOption.EditSong:
                    Console.Clear();
                    _errorsUI.FeatureNotImplemented();
                    break;
                case MainMenuOption.DeleteSong:
                    Console.Clear();
                    _errorsUI.FeatureNotImplemented();
                    break;
                case MainMenuOption.DeleteAllSongs:
                    Console.Clear();
                    _errorsUI.FeatureNotImplemented();
                    break;
                case MainMenuOption.DisplayAllSongs:
                    Console.Clear();
                    _displayAllSongsController.AllSongsMenuController();
                    break;
                case MainMenuOption.SearchSongs:
                    Console.Clear();
                    _errorsUI.FeatureNotImplemented();
                    break;
                case MainMenuOption.Exit:
                    Console.Clear();
                    _informativeUI.FarewellMessage();
                    Environment.Exit(0);
                    return;
            }
        }
        #endregion

        #region Private Enums
        /// <summary>
        /// Represents the options available in the main menu.
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