using System;

namespace CollectionsProject
{
    public class Book : IComparable<Book>
    {
        public int    Id     { get; set; }
        public double Price  { get; set; }
        public string Title  { get; set; }
        public string Author { get; set; }

        public int CompareTo(Book? b)
        {
            // 1 this > b
            // -1 this < b
            // 0 this == b
            if (this.Price > b.Price) return 1;
            if (this.Price < b.Price) return -1;
            return 0;
        }

        public override string ToString()
        {
            return $"id={Id} price={Price}  {Author} : {Title}";
        }
    }
}
