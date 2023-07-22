using MusicCatalogueOrganizer.Models;

namespace MusicCatalogueOrganizer.Data
{
    public interface IMusicCatalogueRepository
    {
        #region Song Management
        void AddSong(Song song);
        void EditSong(Song song);
        void DeleteSong(int id);
        #endregion

        #region Song Retrieval
        List<Song> GetAllSongs();
        List<Song> GetSongsByGenre(string genre);
        List<Song> GetSongsByArtist(string artist);
        Song GetSongById(int id);
        #endregion
    }
}