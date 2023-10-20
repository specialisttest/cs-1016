using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    [AttributeUsage(AttributeTargets.Class)]
    public class AuthorAttribute : Attribute
    {
        private string author;
        public AuthorAttribute(string author = "Unknown")
        {
            this.author = author;
        }

        public override string ToString() => $"Author : {author}";
    }
}
