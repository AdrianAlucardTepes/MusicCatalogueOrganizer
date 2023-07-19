using MusicCatalogueOrganizer.Data;
using MusicCatalogueOrganizer.Models;
using MusicCatalogueOrganizer.UserInterface;

namespace MusicCatalogueOrganizer.Controllers
{
    public class DataController
    {
        private readonly IMusicCatalogueRepository _musicCatalogueRepository;
        private readonly ErrorsUI _errorsUI;

        public DataController(IMusicCatalogueRepository musicCatalogueRepository, ErrorsUI errorsUI)
        {
            _musicCatalogueRepository = musicCatalogueRepository;
            _errorsUI = errorsUI;
        }

        public void AddNewSong()
        {
            Console.Write("Enter song title: ");
            var title = Console.ReadLine();

            Console.Write("Enter song artist: ");
            var artist = Console.ReadLine();

            Console.Write("Enter song genre: ");
            var genre = Console.ReadLine();

            int? rate = null;
            Console.Write("Enter song rate (1-5, leave empty if unknown): ");
            var rateInput = Console.ReadLine();
            if (!string.IsNullOrEmpty(rateInput))
            {
                if (int.TryParse(rateInput, out var rateValue) && rateValue >= 1 && rateValue <= 5)
                {
                    rate = rateValue;
                }
                else
                {
                    _errorsUI.InvalidInput();
                }
            }

            var song = new Song
            {
                Title = title,
                Artist = artist,
                Genre = genre,
                Rate = rate
            };

            _musicCatalogueRepository.AddSong(song);
        }

        public void EditSong()
        {
            Console.Write("Enter song ID to edit: ");
            var idInput = Console.ReadLine();

            if (int.TryParse(idInput, out var id))
            {
                var song = _musicCatalogueRepository.GetSongById(id);
                if (song != null)
                {
                    Console.Write($"Enter new title for song (leave empty to keep current title: {song.Title}): ");
                    var title = Console.ReadLine();
                    if (!string.IsNullOrEmpty(title))
                        song.Title = title;

                    Console.Write($"Enter new artist for song (leave empty to keep current artist: {song.Artist}): ");
                    var artist = Console.ReadLine();
                    if (!string.IsNullOrEmpty(artist))
                        song.Artist = artist;

                    Console.Write($"Enter new genre for song (leave empty to keep current genre: {song.Genre}): ");
                    var genre = Console.ReadLine();
                    if (!string.IsNullOrEmpty(genre))
                        song.Genre = genre;

                    int? rate = null;
                    Console.Write($"Enter new rate for song (1-5, leave empty to keep current rate: {song.Rate}): ");
                    var rateInput = Console.ReadLine();
                    if (!string.IsNullOrEmpty(rateInput))
                    {
                        if (int.TryParse(rateInput, out var rateValue) && rateValue >= 1 && rateValue <= 5)
                        {
                            rate = rateValue;
                        }
                        else
                        {
                            _errorsUI.InvalidInput();
                        }
                    }
                    if (rate.HasValue)
                        song.Rate = rate;

                    _musicCatalogueRepository.EditSong(song);
                }
                else
                {
                    _errorsUI.InvalidID();
                }
            }
            else
            {
                _errorsUI.InvalidID();
            }
        }

        public void DeleteSong()
        {
            Console.Write("Enter song ID to delete: ");
            var idInput = Console.ReadLine();

            if (int.TryParse(idInput, out var id))
            {
                _musicCatalogueRepository.DeleteSong(id);
            }
            else
            {
                _errorsUI.InvalidID();
            }
        }

        public void DisplaySongs()
        {
            var songs = _musicCatalogueRepository.GetAllSongs();

            if (songs.Count == 0)
            {
                _errorsUI.NoSongsFound();
                return;
            }

            Console.WriteLine("{0,-5} {1,-30} {2,-30} {3,-20} {4,-5}", "ID", "Title", "Artist", "Genre", "Rate");
            Console.WriteLine(new string('-', 95));

            foreach (var song in songs)
            {
                Console.WriteLine("{0,-5} {1,-30} {2,-30} {3,-20} {4,-5}", song.Id, song.Title, song.Artist, song.Genre, song.Rate);
            }
        }

    }
}
