using System;

namespace Open_Lab_10._00
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            LOTR.SetAuthor("God - ");
            LOTR.SetCategory("Human - ");
            LOTR.SetTitle("Palko");
            LOTR.SetReleaseDate(16);
            LOTR.SetPages(21);
            LOTR.GetAll();
        }
    }
}
