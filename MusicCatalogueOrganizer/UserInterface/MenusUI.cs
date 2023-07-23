namespace MusicCatalogueOrganizer.UserInterface
{
    public class MenusUI
    {
        #region Private Fields
        private readonly InformativeUI _informativeUI;
        #endregion

        #region Constructor
        public MenusUI(InformativeUI informativeUI)
        {
            _informativeUI = informativeUI;
        }
        #endregion

        #region Public Methods
        public void ShowMainMenu()
        {
            var mainMenuHeadTitleText = "=== Music Catalogue Organizer ===";
            var correspondingKeyText = "\nPress the corresponding function key to select an option:";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(mainMenuHeadTitleText);
            Console.WriteLine(new string('=', mainMenuHeadTitleText.Length));
            Console.ResetColor();

            Console.WriteLine("F1: Add New Song");
            Console.WriteLine("F2: Manage Lists");
            Console.WriteLine("F3: Edit Song");
            Console.WriteLine("F4: Delete Song");
            Console.WriteLine("F5: Delete All Songs");
            Console.WriteLine("F6: Display All Songs");
            Console.WriteLine("F7: Search Songs");
            Console.WriteLine("F8: Exit");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(correspondingKeyText);
            Console.WriteLine(new string('=', correspondingKeyText.Length));
            Console.ResetColor();
        }

        public void ShowSongsListMenu()
        {
            var header = $"=== List Of Songs Menu. ===";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(header);
            Console.WriteLine(new string('-', header.Length));
            Console.ResetColor();

            _informativeUI.DisplayTotalCountedSongs();

            Console.WriteLine("F1: Display Order: Creation Date.");
            Console.WriteLine("F2: Display Order: Song Name Alphabetical.");
            Console.WriteLine("F3: Display Order: Release Date.");
            Console.WriteLine("F4: Display Order: By Rate.");
            Console.WriteLine("F5: Display Order: Genre Alphabetical");
            Console.WriteLine("F6: Display Order: By Album Alphabetical.");
            Console.WriteLine("F7: Display Order: By Album Release Date.");
            Console.WriteLine("F8: Manual Search.");
            Console.WriteLine("F9: Return To Main Menu.");
            Console.WriteLine("F10: Exit.");

            Console.WriteLine();
        }
        #endregion
    }
}