using MusicCatalogueOrganizer.Data;
using MusicCatalogueOrganizer.Models;
using MusicCatalogueOrganizer.UserInterface;

namespace MusicCatalogueOrganizer.Controllers
{
    /// <summary>
    /// The DisplayAllSongsController class is responsible for displaying all songs in the catalog.
    /// </summary>
    public class DisplayAllSongsController
    {
        #region Private Fields
        // The repository used to manage the data.
        private readonly IMusicCatalogueRepository _musicCatalogueRepository;
        // The user interface used to display errors.
        private readonly ErrorsUI _errorsUI;
        // The user interface used to display menus.
        private readonly MenusUI _menusUI;
        // The user interface used to display information.
        private readonly InformativeUI _informativeUI;
        // The selected sorting option.
        private SortOption _selectedSortOption = SortOption.CreationDate;
        // The current order of the songs (true for ascending, false for descending).
        private bool _isAscendingOrder = true;
        #endregion

        #region Constructor
        /// <summary>
        /// Initializes a new instance of the DisplayAllSongsController class with the specified dependencies.
        /// </summary>
        /// <param name="musicCatalogueRepository">The repository used to manage the data.</param>
        /// <param name="errorsUI">The user interface used to display errors.</param>
        /// <param name="menusUI">The user interface used to display menus.</param>
        /// <param name="informativeUI">The user interface used to display information.</param>
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
        /// Displays the songs menu and handles user input.
        /// </summary>
        public void DisplaySongsMenuManager()
        {
            var songs = _musicCatalogueRepository.GetAllSongs();

            while (true)
            {
                Console.Clear();
                _menusUI.ShowSongsListMenu();
                DisplaySongs(songs);

                var key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.F1:
                        // Toggle the order of the songs between ascending and descending.
                        _isAscendingOrder = !_isAscendingOrder;
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
                        // Perform a manual search
                        break;
                    case ConsoleKey.F9:
                        Console.Clear();
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
        /// Sorts and displays the specified songs based on the selected sorting option and order.
        /// </summary>
        /// <param name="songs">The songs to sort and display.</param>
        private void DisplaySongs(List<Song> songs)
        {
            // Sort the songs based on the selected sorting option and order.
            switch (_selectedSortOption)
            {
                case SortOption.CreationDate:
                    if (_isAscendingOrder)
                        songs = songs.OrderBy(s => s.CreationDate).ToList();
                    else
                        songs = songs.OrderByDescending(s => s.CreationDate).ToList();
                    break;

                case SortOption.SongNameAlphabetical:
                    // TODO: Implement sorting by song name alphabetical.
                    break;
                case SortOption.ReleaseDate:
                    // TODO: Implement sorting by release date.
                    break;
                case SortOption.Rate:
                    // TODO: Implement sorting by rate.
                    break;
                case SortOption.GenreAlphabetical:
                    // TODO: Implement sorting by genre alphabetical.
                    break;
                case SortOption.AlbumAlphabetical:
                    // TODO: Implement sorting by album alphabetical.
                    break;
                case SortOption.AlbumReleaseDate:
                    // TODO: Implement sorting by album release date.
                    break;
            }

            // Display the sorted songs.
            _informativeUI.DisplayOrder(_isAscendingOrder);
            _informativeUI.DisplayAllSongs(songs);
        }

        public enum SortOption
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