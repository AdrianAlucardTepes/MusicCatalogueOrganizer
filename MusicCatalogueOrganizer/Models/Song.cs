namespace MusicCatalogueOrganizer.Models
{
    public class Song
    {
        #region Properties
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public string Genre { get; set; }
        public int? Rate { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ReleaseDate { get; set; }
        #endregion
    }
}