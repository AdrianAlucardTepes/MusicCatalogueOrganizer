using MusicCatalogueOrganizer.Controllers;
using MusicCatalogueOrganizer.Data;

namespace MusicCatalogueOrganizer.UserInterface
{
    public class MenusUI
    {
        private readonly MainMenuController _controller;

        public MenusUI(IMusicCatalogueRepository repository)
        {
            _controller = new MainMenuController(repository);
        }

        public void ShowMainMenu()
        {
            while (true)
            {
                Console.WriteLine("Welcome to MusicCatalogueOrganizer!");
                Console.WriteLine();
                Console.WriteLine("Please choose an option:");
                Console.WriteLine("F1. Add new song");
                Console.WriteLine("F2. Edit a song");
                Console.WriteLine("F3. Delete a song");
                Console.WriteLine("F4. Display songs");
                Console.WriteLine("F5. Search for songs");
                Console.WriteLine("F6. Exit");
                Console.WriteLine();

                var key = Console.ReadKey().Key;

                _controller.HandleInput(key);

                Console.WriteLine();
            }
        }
    }
}