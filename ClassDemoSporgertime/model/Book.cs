using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoSporgertime.model
{
    public class Book:Media
    {
        private string _isbn;

        public Book()
        {
            
        }

        public Book(int mediaId, string title, string author, string publisher, int year, string isbn) : base(mediaId, title, author, publisher, year)
        {
            _isbn = isbn;
        }

        public string Isbn
        {
            get => _isbn;
            set => _isbn = value;
        }

        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(Isbn)}: {Isbn}";
        }
    }
}
