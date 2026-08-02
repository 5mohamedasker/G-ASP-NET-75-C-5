namespace ConsoleApp5
{
    internal class Book
    {
        private string password = "secret";
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            ////1.Add a private string password = "secret"; field to a Book class.
            ////Try to print it from Main (outside the class).
            ////What happens, and why?
            //Book book = new Book();
            //Console.WriteLine(book.password);
            ///*What happens, And why
            // Error
            // because I don't have permission to use the password
            // outside of the class.
            //*/
            #endregion
        }
    }
}
