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
        private SortOption _selectedSortOption = SortOption.CreationDate;
        private bool _isSortedAscending = true;
        #endregion

        #region Constructor 
        public DisplayAllSongsController(IMusicCatalogueRepository musicCatalogueRepository, ErrorsUI errorsUI, MenusUI menusUI, InformativeUI informativeUI)
        {
            _musicCatalogueRepository = musicCatalogueRepository;
            _errorsUI = errorsUI;
            _menusUI = menusUI;
            _informativeUI = informativeUI;
        }
        #endregion

        public void AllSongsMenuController()
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
                        SortOptionHandler(ConsoleKey.F1, songs);
                        break;

                    case ConsoleKey.F2:
                        SortOptionHandler(ConsoleKey.F2, songs);
                        break;

                    case ConsoleKey.F3:
                        SortOptionHandler(ConsoleKey.F3, songs);
                        break;

                    case ConsoleKey.F4:
                        SortOptionHandler(ConsoleKey.F4, songs);
                        break;

                    case ConsoleKey.F5:
                        SortOptionHandler(ConsoleKey.F5, songs);
                        break;

                    case ConsoleKey.F6:
                        SortOptionHandler(ConsoleKey.F6, songs);
                        break;

                    case ConsoleKey.F7:
                        SortOptionHandler(ConsoleKey.F7, songs);
                        break;

                    case ConsoleKey.F8:
                        SortOptionHandler(ConsoleKey.F8, songs);
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
                        _menusUI.ShowSongsListMenu();
                        _informativeUI.DisplayAllSongs(songs);
                        break;
                }
            }
        }

        private void SortOptionHandler(ConsoleKey key, List<Song> songs)
        {
            switch (key)
            {
                case ConsoleKey.F1:
                    _selectedSortOption = SortOption.CreationDate;
                    _isSortedAscending = !_isSortedAscending;
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
                    //Search Song.
                    break;
                default:
                    Console.Clear();
                    return;
            }

            ActionsHandler(songs);
        }

        private void ActionsHandler(List<Song> songs)
        {
            switch (_selectedSortOption)
            {
                case SortOption.CreationDate:
                    SortByCreationDate(songs);
                    break;

                case SortOption.SongNameAlphabetical:
                    Console.Clear();
                    _errorsUI.FeatureNotImplemented();
                    _menusUI.ShowSongsListMenu();
                    _informativeUI.DisplayAllSongs(songs);
                    break;

                case SortOption.ReleaseDate:
                    Console.Clear();
                    _errorsUI.FeatureNotImplemented();
                    _menusUI.ShowSongsListMenu();
                    _informativeUI.DisplayAllSongs(songs);
                    break;

                case SortOption.Rate:
                    Console.Clear();
                    _errorsUI.FeatureNotImplemented();
                    _menusUI.ShowSongsListMenu();
                    _informativeUI.DisplayAllSongs(songs);
                    break;

                case SortOption.GenreAlphabetical:
                    Console.Clear();
                    _errorsUI.FeatureNotImplemented();
                    _menusUI.ShowSongsListMenu();
                    _informativeUI.DisplayAllSongs(songs);
                    break;

                case SortOption.AlbumAlphabetical:
                    Console.Clear();
                    _errorsUI.FeatureNotImplemented();
                    _menusUI.ShowSongsListMenu();
                    _informativeUI.DisplayAllSongs(songs);
                    break;

                case SortOption.AlbumReleaseDate:
                    Console.Clear();
                    _errorsUI.FeatureNotImplemented();
                    _menusUI.ShowSongsListMenu();
                    _informativeUI.DisplayAllSongs(songs);
                    break;

                default:
                    Console.Clear();
                    break;
            }
        }

        private void SortByCreationDate(List<Song> songs)
        {
            Console.Clear();
            if (_isSortedAscending)
                songs = songs.OrderBy(song => song.CreationDate).ToList();
            else
                songs = songs.OrderByDescending(song => song.CreationDate).ToList();

            _menusUI.ShowSongsListMenu();
            _informativeUI.DisplayAllSongs(songs);
        }

        #region Private Enum
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