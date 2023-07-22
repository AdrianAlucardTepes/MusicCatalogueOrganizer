using MusicCatalogueOrganizer.Data;
using MusicCatalogueOrganizer.UserInterface;

namespace MusicCatalogueOrganizer.Controllers
{
    public class DataController
    {
        #region Private Fields
        private readonly IMusicCatalogueRepository _musicCatalogueRepository;
        private readonly ErrorsUI _errorsUI;
        private readonly MenusUI _menusUI;
        private readonly InformativeUI _informativeUI;
        #endregion

        #region Constructor
        public DataController(IMusicCatalogueRepository musicCatalogueRepository, ErrorsUI errorsUI, MenusUI menusUI, InformativeUI informativeUI)
        {
            _musicCatalogueRepository = musicCatalogueRepository;
            _errorsUI = errorsUI;
            _menusUI = menusUI;
            _informativeUI = informativeUI;
        }
        #endregion

        #region Public Methods
        public void DisplaySongs()
        {
            var songs = _musicCatalogueRepository.GetAllSongs();

            if (songs.Count == 0)
            {
                _errorsUI.NoSongsFound();
                return;
            }

            _menusUI.ShowSongsListMenu();
            _informativeUI.DisplayAllSongs(songs);
        }
        #endregion
    }
}