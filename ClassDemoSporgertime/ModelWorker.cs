using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassDemoSporgertime.model;

namespace ClassDemoSporgertime
{
    class ModelWorker
    {
        public void Start()
        {
            Media m = new Media();
            Console.WriteLine(m);

            Media m2 = new Media(3, "Hobit", "Tolkin", "Press", 1941);
            Console.WriteLine(m2.ToString());

            Book b = new Book(4, "agile Samurai", "forfatter", "gyldendal", 2011, "12-135-1266-4532");
            Console.WriteLine(b);


            MediaKatalog katalog = new MediaKatalog();
            katalog.AddMedia(m2);
            katalog.AddMedia(b);

            katalog.PrintAll();

            Media mFundet = katalog.GetMediaById(3);
            Console.WriteLine("Fundet: " + mFundet);

            try
            {
                Media mIkkeFundet = katalog.GetMediaById(44);
                Console.WriteLine("Ikke Fundet: " + mIkkeFundet);
            }
            catch (KeyNotFoundException knfe)
            {
                Console.WriteLine("Desværre mediet kunne ikke findes "  + 44);
            }


        }
    }
}
