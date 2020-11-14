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
            LOTR.ReleaseDate = 1449;
            LOTR.Title = "Dobrodružstvo pri obžinkoch";
            LOTR.Pages = -2;
            Console.WriteLine(LOTR.Category);
            Console.WriteLine(LOTR.Author);
            Console.WriteLine(LOTR.ReleaseDate);
            Console.WriteLine(LOTR.Title);
            Console.WriteLine(LOTR.Pages);
        }
    }
}
