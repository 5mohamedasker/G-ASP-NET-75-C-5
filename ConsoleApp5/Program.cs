using System.Drawing;

namespace ConsoleApp5
{
    internal class Book
    {
        private string password = "secret";
        internal int copiesInStock = 5;
        public string title = "C#";
        internal Genre genre { get; set; } 
    }
    internal enum Genre
    { 
        Fiction=1,
        NonFiction,
        Science
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
            #region Question04
            ////4.Declare an enum Genre { Fiction, NonFiction, Science }.
            ////Add a Genre property to Book,
            ////assign it Genre.Science, and print it.
            //Book book = new Book();
            //book.genre = Genre.Science;
            //Console.WriteLine(book.genre);
            #endregion
            #region Question05
            ////5.Using the Genre enum above, print the underlying int value of
            ////Genre.Fiction, Genre.NonFiction, and Genre.Science
            ////by casting each to int.
            //Console.WriteLine((int)Genre.Fiction);
            //Console.WriteLine((int)Genre.NonFiction);
            //Console.WriteLine((int)Genre.Science);
            #endregion
            #region Question06
            ////6.Given int genreNumber = 1;
            ////cast it into a Genre value and print the result.
            //int genreNumber = 1;
            //Console.WriteLine((Genre)genreNumber);
            #endregion
        }
    }
}
