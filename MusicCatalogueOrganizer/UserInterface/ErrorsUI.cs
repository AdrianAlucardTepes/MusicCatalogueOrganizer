namespace MusicCatalogueOrganizer.UserInterface
{
    public class ErrorsUI
    {
        public void InvalidInput()
        {
            DisplayErrorUI("Invalid Input Key, Please Retry.");
        }

        public void InvalidID()
        {
            DisplayErrorUI("Invalid Id, Please Retry.");
        }

        private void DisplayErrorUI(string errorMessage)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(errorMessage);
            Console.WriteLine(new string('-', errorMessage.Length));
            Console.ResetColor();

            Console.WriteLine();
        }
    }
}
