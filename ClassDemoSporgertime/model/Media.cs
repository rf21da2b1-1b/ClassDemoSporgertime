using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoSporgertime.model
{
    public class Media
    {
        private int _mediaId;
        private string _title;
        private string _author;
        private string _publisher;
        private int _year;

        /*
         * konstruktører
         */
        public Media() // default
        {
        }

        public Media(int mediaId, string title, string author, string publisher, int year)
        {
            _mediaId = mediaId;
            _title = title;
            _author = author;
            _publisher = publisher;
            _year = year;
        }

        /*
         * Properties
         */
        public int MediaId
        {
            get { return _mediaId; }
            set { _mediaId = value;  }
        }

        public string Title
        {
            get => _title;
            set => _title = value;
        }

        public string Author
        {
            get => _author;
            set => _author = value;
        }

        public string Publisher
        {
            get => _publisher;
            set => _publisher = value;
        }

        public int Year
        {
            get => _year;
            set => _year = value;
        }


        /*
         * ToString -- samle og returnere alle værdier i objktet i en tekst string
         */
        //public override string ToString()
        //{
        //    return $"ID={_mediaId}, Title={_title}, Author={_author}, Publisher={_publisher}, Year={_year}";
        //}

        public override string ToString()
        {
            return $"{nameof(MediaId)}: {MediaId}, {nameof(Title)}: {Title}, {nameof(Author)}: {Author}, {nameof(Publisher)}: {Publisher}, {nameof(Year)}: {Year}";
        }
    }
}
