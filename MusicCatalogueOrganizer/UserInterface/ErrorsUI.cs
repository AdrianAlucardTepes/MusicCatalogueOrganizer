namespace MusicCatalogueOrganizer.UserInterface
{
    public class ErrorsUI
    {
        #region Public Methods
        public void InvalidInput()
        {
            DisplayErrorUI("Invalid Input Key, Please Retry.");
        }
        public void InvalidID()
        {
            DisplayErrorUI("Invalid Id, Please Retry.");
        }
        public void NoSongsFound()
        {
            DisplayErrorUI("No songs found.");
        }

        public void FeatureNotImplemented()
        {
            DisplayErrorUI("This feature is not implemented yet.");
        }

        #endregion

        #region Private Methods
        private void DisplayErrorUI(string errorMessage)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(errorMessage);
            Console.WriteLine(new string('-', errorMessage.Length));
            Console.ResetColor();

            Console.WriteLine();
        }
        #endregion
    }
}