using MusicCatalogueOrganizer.Models;

namespace MusicCatalogueOrganizer.Data
{
    public class MusicCatalogueRepository : IMusicCatalogueRepository
    {
        private List<Song> _songs = new List<Song>();
        private int _nextId = 1;

        public void AddSong(Song song)
        {
            song.Id = _nextId++;
            song.CreationDate = DateTime.Now;
            _songs.Add(song);
        }

        public void EditSong(Song song)
        {
            var existingSong = _songs.FirstOrDefault(s => s.Id == song.Id);
            if (existingSong != null)
            {
                existingSong.Title = song.Title;
                existingSong.Artist = song.Artist;
                existingSong.Genre = song.Genre;
                existingSong.Rate = song.Rate;
            }
        }

        public void DeleteSong(int id)
        {
            var song = _songs.FirstOrDefault(s => s.Id == id);
            
            if (song != null)
                _songs.Remove(song);
        }

        public List<Song> GetAllSongs()
        {
            return _songs.ToList();
        }

        public List<Song> GetSongsByGenre(string genre)
        {
            return _songs.Where(s => s.Genre == genre).ToList();
        }

        public List<Song> GetSongsByArtist(string artist)
        {
            return _songs.Where(s => s.Artist == artist).ToList();
        }

        public Song GetSongById(int id)
        {
            return _songs.FirstOrDefault(s => s.Id == id);
        }
    }
}