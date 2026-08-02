namespace ConsoleApp5
{
    internal class Book
    {
        private string password = "secret";
        internal int copiesInStock = 5;
        public string title = "C#";    
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
            #region Question02
            ////2.Add an internal int copiesInStock = 5; field to Book.
            ////Print it from Main. Does it compile? Why ?
            //Book book = new Book();
            //Console.WriteLine(book.copiesInStock);
            ///* Does it compile? Why ?
            // yes it compiled.
            // Because I can use it since I have the permission
            // to use it anywhere in my project only.
            // */
            #endregion
            #region Question03
            ////3.Add a public string Title; field to Book.
            ////Set it and print it from Main.
            //Book book = new Book();
            //Console.WriteLine(book.title);
            #endregion
        }
    }
}
