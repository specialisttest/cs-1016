using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    public class Books2 : IEnumerable<Book>
    {
        private Book[] books;
        public Books2() { books = Books.TestBooks; }

        public IEnumerator<Book> GetEnumerator()
        {
            return ((IEnumerable<Book>)books).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return books.GetEnumerator();
        }

        public void Add(Book value)
        { 
        }

        
    }
}
