using System.ComponentModel.DataAnnotations;

namespace MusicCatalogueOrganizer.Models
{
    public class Song
    {
        #region Properties
        public int Id { get; set; }

        [Required(ErrorMessage = "The Title field is required.")]
        [StringLength(100, ErrorMessage = "The Title must be less than {1} characters.")]
        public string Title { get; set; }

        [StringLength(100, ErrorMessage = "The Artist must be less than {1} characters.")]
        public string Artist { get; set; }

        [StringLength(100, ErrorMessage = "The Album must be less than {1} characters.")]
        public string Album { get; set; }

        [StringLength(50, ErrorMessage = "The Genre must be less than {1} characters.")]
        public string Genre { get; set; }

        [Range(0, 5, ErrorMessage = "The Rate must be between {1} and {2}.")]
        public int? Rate { get; set; }

        public DateTime CreationDate { get; set; }
        public DateTime? ReleaseDate { get; set; }
        #endregion
    }
}