namespace MusicCatalogueOrganizer.UserInterface
{
    public class MenusUI
    {
        public void ShowMainMenu()
        {
            var mainMenuHeadTitleText = "=== Music Catalogue Organizer ===";
            var correspondingKeyText = "\nPress the corresponding function key to select an option:";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(mainMenuHeadTitleText);
            Console.WriteLine(new string('-', mainMenuHeadTitleText.Length));
            Console.ResetColor();

            Console.WriteLine("F1: Add new song");
            Console.WriteLine("F2: Edit a song");
            Console.WriteLine("F3: Delete a song");
            Console.WriteLine("F4: Display songs");
            Console.WriteLine("F5: Search for songs");
            Console.WriteLine("F6: Exit");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(correspondingKeyText);
            Console.WriteLine(new string('-', correspondingKeyText.Length));
            Console.ResetColor();

            Console.WriteLine();
        }
    }
}