using Delegate_Predicate.Models;

namespace Delegate_Predicate
{
    internal class BookDelegate
    {
        public delegate bool CheckAuthor(List<Book> books);

        public void ShowCountOfBook(List<Book> books, Predicate<Book> predicate)
        {
            int count = 0;
            foreach (Book book in books)
            {
                if (predicate(book))
                {
                    count++;
                }
            }
            Console.WriteLine(count);

        }

        public void Result()
        {
            List<Book> books = new List<Book>()
            {
              new Book() {Author="Nizami Gencevi", Name="Isgendername"},
              new Book() {Author="Nizami Gencevi", Name="Isgendername"},
              new Book() {Author="Mehemmed Fizuli", Name="Leyli ve Mecnun"},
              new Book() {Author="Mehemmed Fizuli", Name="Divan-ı Füzuli"},
            };
            ShowCountOfBook(books, books => books.Author == "Nizami Gencevi");
        }
    }
}
