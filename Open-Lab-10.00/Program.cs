using System;
using System.Collections.Generic;

namespace Open_Lab_10._00
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            LOTR.Category = "komix";
            LOTR.Author = "Ján Palárik";
            LOTR.ReleaseDate = 11500;
            LOTR.Title = "Dobrodružstvo pri obžinkoch";
            LOTR.Pages = -165465;
            Console.WriteLine(LOTR.ToString());

            Console.WriteLine();
            Book LOTR2 = new Book();
            Console.WriteLine(LOTR2.ToString());

            Console.WriteLine();
            Book LOTR3 = new Book("Palko", 254);
            Console.WriteLine(LOTR3.ToString());

            Console.WriteLine();
            Book HOBIT = new Book("komix", "Ján Palárik", 1500, "Dobrodružstvo pri pbžinkoch", 1563);
            HOBIT.category();
            Console.WriteLine();
            Console.WriteLine(HOBIT.ToString());


        }
    }
}
