using System;

namespace Open_Lab_10._00
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            LOTR.Category = "komix";
            LOTR.Author = "Ján Palárik";
            LOTR.ReleaseDate = 1500;
            LOTR.Title = "Dobrodružstvo pri obžinkoch";
            LOTR.Pages = 165465;
            Console.WriteLine(LOTR.Category);
            Console.WriteLine(LOTR.Author);
            Console.WriteLine(LOTR.ReleaseDate);
            Console.WriteLine(LOTR.Title);
            Console.WriteLine(LOTR.Pages);

            Console.WriteLine();
            Book LOTR2 = new Book();
            Console.WriteLine(LOTR2.Category);
            Console.WriteLine(LOTR2.Author);
            Console.WriteLine(LOTR2.ReleaseDate);
            Console.WriteLine(LOTR2.Title);
            Console.WriteLine(LOTR2.Pages);

            Console.WriteLine();
            Book LOTR3 = new Book("Palko", 254);
            Console.WriteLine(LOTR3.Title);
            Console.WriteLine(LOTR3.Pages);
            Console.WriteLine(LOTR3.Category);
            Console.WriteLine(LOTR3.Author);
            Console.WriteLine(LOTR3.ReleaseDate);

            Console.WriteLine();
            Book HOBIT = new Book("komix", "Ján Palárik", 1500, "Dobrodružstvo pri pbžinkoch", 1563);
            Console.WriteLine(HOBIT.Category);
            Console.WriteLine(HOBIT.Author);
            Console.WriteLine(HOBIT.ReleaseDate);
            Console.WriteLine(HOBIT.Title);
            Console.WriteLine(HOBIT.Pages);
        }
    }
}
