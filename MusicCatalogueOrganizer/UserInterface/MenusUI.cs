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
            DisplayMenuHeader("=== Music Catalogue Organizer ===");

            DisplayMenuOptions(new[]
            {
                "F1: Add New Song",
                "F2: Manage Lists",
                "F3: Edit Song",
                "F4: Delete Song",
                "F5: Delete All Songs",
                "F6: Display All Songs",
                "F7: Search Songs",
                "F8: Exit"
            });

            DisplayMenuFooter("\nPress the corresponding function key to select an option:");
        }
        public void ShowSongsListMenu()
        {
            DisplayMenuHeader("=== List Of Songs Menu. ===");

            _informativeUI.DisplayTotalCountedSongs();

            DisplayMenuOptions(new[]
            {
                "F1: Display Order: Creation Date.",
                "F2: Display Order: Song Name Alphabetical.",
                "F3: Display Order: Release Date.",
                "F4: Display Order: By Rate.",
                "F5: Display Order: Genre Alphabetical",
                "F6: Display Order: By Album Alphabetical.",
                "F7: Display Order: By Album Release Date.",
                "F8: Manual Search.",
                "F9: Return To Main Menu.",
                "F10: Exit."
            });

            DisplayMenuFooter("\nPress the corresponding function key to select an option:");
        }
        #endregion

        #region Private Methods
        private void DisplayMenuHeader(string title)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(title);
            Console.WriteLine(new string('=', title.Length));
            Console.ResetColor();
        }

        private void DisplayMenuOptions(string[] options)
        {
            foreach (var option in options)
                Console.WriteLine(option);
        }

        private void DisplayMenuFooter(string footer)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(footer);
            Console.WriteLine(new string('=', footer.Length));
            Console.ResetColor();
        }
        #endregion
    }
}