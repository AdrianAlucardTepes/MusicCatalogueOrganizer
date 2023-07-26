using MusicCatalogueOrganizer.Data;
using MusicCatalogueOrganizer.UserInterface;

namespace MusicCatalogueOrganizer.Controllers
{
    public class DataController
    {
        #region Private Fields
        private readonly IMusicCatalogueRepository _musicCatalogueRepository;
        private readonly ErrorsUI _errorsUI;
        private readonly InformativeUI _informativeUI;
        #endregion

        #region Constructor
        public DataController(IMusicCatalogueRepository musicCatalogueRepository, ErrorsUI errorsUI, InformativeUI informativeUI)
        {
            _musicCatalogueRepository = musicCatalogueRepository;
            _errorsUI = errorsUI;
            _informativeUI = informativeUI;
        }
        #endregion

        #region Public Methods
        public void DisplayAllSongsManager()
        {
            var songs = _musicCatalogueRepository.GetAllSongs();

            if (songs.Count == 0)
            {
                _errorsUI.NoSongsFound();
                return;
            }
            _informativeUI.DisplayAllSongs(songs);
        }
        #endregion
    }
}