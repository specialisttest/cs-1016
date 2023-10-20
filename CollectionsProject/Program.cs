using System.Collections.Generic;
using System.Collections.Specialized;

namespace CollectionsProject
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Book> books = new List<Book>()
            {
                new Book() {Id=1, Price=32, Author="Seemann", Title="Dependency Injection in .NET" },
                new Book() {Id=2, Price=42, Author="Richter", Title="CLR via C#" },
                new Book() {Id=22, Price=42, Author="Richter", Title="CLR via C# 8" },
                new Book() {Id=3, Price=21, Author="Munro", Title="ASP.NET MVC 5" },
                new Book() {Id=5, Price=30, Author="Esposito", Title="Architecting Applications for the Enterprise" },
                new Book() {Id=6, Price=23, Author="Watson", Title="Writing High-Performance .NET Code" },
                new Book() {Id=7, Price=37, Author="Sharp", Title="Microsoft Visual C# 2013" },
                new Book() {Id=9, Price=11, Author="Stubblebine", Title="Regular Expression" },
                new Book() {Id=10, Price=27, Author="Liberty", Title="Learning Visual Basic .Net" },
                new Book() {Id=11, Price=62, Author="Cwalina", Title="Framework Design Guidelines" },
                new Book() {Id=12, Price=55, Author="Blewett", Title="Pro Asynchronous Programming with .NET" },
                new Book() {Id=13, Price=47, Author="Nathan", Title="Windows Presentation Foundation Unleashed" },

            };

            Console.WriteLine(books.Count);
            
            books.Sort(delegate (Book b1, Book b2)
            {
                return b1.Title.CompareTo(b2.Title);
            });
            books.Sort((b1, b2) => b1.Title.CompareTo(b2.Title));
            
            books.Sort((b1, b2) => {
                int k = b1.Author.CompareTo(b2.Author);
                return k != 0 ? k : b1.Title.CompareTo(b2.Title);
            });

            foreach (var b in books)
                Console.WriteLine(b);

            // NameValueCollection
            IDictionary<string, string> d = new Dictionary<string, string>
            {
                { "red", "Красный" },
                { "green", "Зеленый" },
                { "blue", "Синий" }
            };

            d.Add("sun", "солнце");

            string engl = "red";
            Console.WriteLine(d[engl]);





        }
    }
}
