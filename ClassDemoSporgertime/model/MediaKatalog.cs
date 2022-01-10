using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemoSporgertime.model
{
    public class MediaKatalog
    {
        // collection
        private List<Media> _medier;

        public MediaKatalog()
        {
            _medier = new List<Media>();
        }


        /*
         * Metoder
         */

        public void AddMedia(Media media)
        {
            _medier.Add(media);
        }

        public void PrintAll()
        {
            Console.WriteLine("Media katalog");
            foreach (Media m in _medier)
            {
                Console.WriteLine(m);
            }
        }

        public Media GetMediaById(int id)
        {
            foreach (Media m in _medier)
            {
                if (m.MediaId == id)
                {
                    return m;
                }
            }


            //return null;
            throw new KeyNotFoundException();
        }


    }
}
