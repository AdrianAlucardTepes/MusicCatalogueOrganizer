using MusicCatalogueOrganizer.Data;
using MusicCatalogueOrganizer.Models;
using MusicCatalogueOrganizer.UserInterface;

namespace MusicCatalogueOrganizer.Controllers
{
    /// <summary>
    /// The DisplayAllSongsController class is responsible for managing the display of all songs in the application.
    /// </summary>
    public class DisplayAllSongsController
    {
        #region Private Fields
        // Dependencies
        private readonly IMusicCatalogueRepository _musicCatalogueRepository;
        private readonly ErrorsUI _errorsUI;
        private readonly MenusUI _menusUI;
        private readonly InformativeUI _informativeUI;
        // Sorting options
        private SortOption _selectedSortOption = SortOption.CreationDate;
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the DisplayAllSongsController class with the specified dependencies.
        /// </summary>
        /// <param name="musicCatalogueRepository">The IMusicCatalogueRepository instance to use for retrieving songs.</param>
        /// <param name="errorsUI">The ErrorsUI instance to use for displaying error messages.</param>
        /// <param name="menusUI">The MenusUI instance to use for displaying menus.</param>
        /// <param name="informativeUI">The InformativeUI instance to use for displaying informative messages.</param>
        public DisplayAllSongsController(IMusicCatalogueRepository musicCatalogueRepository, ErrorsUI errorsUI, MenusUI menusUI, InformativeUI informativeUI)
        {
            _musicCatalogueRepository = musicCatalogueRepository;
            _errorsUI = errorsUI;
            _menusUI = menusUI;
            _informativeUI = informativeUI;
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Displays the songs list menu to the user and handles user input.
        /// </summary>
        public void DisplaySongsMenuManager()
        {
            var songs = _musicCatalogueRepository.GetAllSongs();
            
            while (true)
            {
                // Show the songs list menu
                _menusUI.ShowSongsListMenu();

                // Display all songs
                _informativeUI.DisplayAllSongs(songs);

                // Get the user's input
                var key = Console.ReadKey(true).Key;

                // Determine which option the user selected
                switch (key)
                {
                    case ConsoleKey.F1:
                        DisplaySongsListOptions(ConsoleKey.F1, songs);
                        break;
                    case ConsoleKey.F2:
                        DisplaySongsListOptions(ConsoleKey.F2, songs);
                        break;
                    case ConsoleKey.F3:
                        DisplaySongsListOptions(ConsoleKey.F3, songs);
                        break;
                    case ConsoleKey.F4:
                        DisplaySongsListOptions(ConsoleKey.F4, songs);
                        break;
                    case ConsoleKey.F5:
                        DisplaySongsListOptions(ConsoleKey.F5, songs);
                        break;
                    case ConsoleKey.F6:
                        DisplaySongsListOptions(ConsoleKey.F6, songs);
                        break;
                    case ConsoleKey.F7:
                        DisplaySongsListOptions(ConsoleKey.F7, songs);
                        break;
                    case ConsoleKey.F8:
                        DisplaySongsListOptions(ConsoleKey.F8, songs);
                        break;
                    case ConsoleKey.F9:
                        Console.Clear();
                        // Return to Main Menu
                        return;
                    case ConsoleKey.F10:
                        Console.Clear();
                        _informativeUI.FarewellMessage();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        _errorsUI.InvalidInput();
                        break;
                }
            }
        }
        #endregion

        #region Private Methods
        /// <summary>
        /// Display the songs list based on the selected sort option.
        /// </summary>
        /// <param name="key">The console key representing the selected sort option.</param>
        /// <param name="songs">The list of songs to display.</param>
        private void DisplaySongsListOptions(ConsoleKey key, List<Song> songs)
        {
            // Set the selected sort option based on the pressed key
            switch (key)
            {
                case ConsoleKey.F1:
                    _selectedSortOption = SortOption.CreationDate;
                    break;
                case ConsoleKey.F2:
                    _selectedSortOption = SortOption.SongNameAlphabetical;
                    break;
                case ConsoleKey.F3:
                    _selectedSortOption = SortOption.ReleaseDate;
                    break;
                case ConsoleKey.F4:
                    _selectedSortOption = SortOption.Rate;
                    break;
                case ConsoleKey.F5:
                    _selectedSortOption = SortOption.GenreAlphabetical;
                    break;
                case ConsoleKey.F6:
                    _selectedSortOption = SortOption.AlbumAlphabetical;
                    break;
                case ConsoleKey.F7:
                    _selectedSortOption = SortOption.AlbumReleaseDate;
                    break;
                case ConsoleKey.F8:
                    break;
                default:
                    Console.Clear();
                    _errorsUI.InvalidInput();
                    return;
            }

            DisplaySongs(songs);
        }

        /// <summary>
        /// Sorts and displays the list of songs.
        /// </summary>
        /// <param name="songs">The list of songs to sort and display.</param>
        private void DisplaySongs(List<Song> songs)
        {
            // Sort the songs based on the selected sorting option.
            switch (_selectedSortOption)
            {
                case SortOption.CreationDate:
                    Console.Clear();
                    _errorsUI.FeatureNotImplemented();
                    break;
                case SortOption.SongNameAlphabetical:
                    Console.Clear();
                    _errorsUI.FeatureNotImplemented();
                    break;
                case SortOption.ReleaseDate:
                    Console.Clear();
                    _errorsUI.FeatureNotImplemented();
                    break;
                case SortOption.Rate:
                    Console.Clear();
                    _errorsUI.FeatureNotImplemented();
                    break;
                case SortOption.GenreAlphabetical:
                    Console.Clear();
                    _errorsUI.FeatureNotImplemented();
                    break;
                case SortOption.AlbumAlphabetical:
                    Console.Clear();
                    _errorsUI.FeatureNotImplemented();
                    break;
                case SortOption.AlbumReleaseDate:
                    Console.Clear();
                    _errorsUI.FeatureNotImplemented();
                    break;
                default:
                    Console.Clear();
                    break;
            }
        }
        #endregion

        #region Private Enums
        /// <summary>
        /// Represents the sorting options available for the list of songs.
        /// </summary>
        private enum SortOption
        {
            CreationDate,
            SongNameAlphabetical,
            ReleaseDate,
            Rate,
            GenreAlphabetical,
            AlbumAlphabetical,
            AlbumReleaseDate
        }
        #endregion
    }
}