using MusicCatalogueOrganizer.Models;

namespace MusicCatalogueOrganizer.Data
{
    public interface IMusicCatalogueRepository
    {
        void AddSong(Song song);
        void EditSong(Song song);
        void DeleteSong(int id);
        List<Song> GetAllSongs();
        List<Song> GetSongsByGenre(string genre);
        List<Song> GetSongsByArtist(string artist);
        Song GetSongById(int id);
    }
}