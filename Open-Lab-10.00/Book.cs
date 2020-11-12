using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_10._00
{
    class Book
    {
        private string author;
        private string category;
        private string title;
        private int releaseDate;
        private int pages;

        public void SetCategory(string Category)
        {
            category = Category;
        }
        public void SetAuthor(string Author)
        {
            author = Author;
        }
        public void SetReleaseDate(int ReleaseDate)
        {
            releaseDate = ReleaseDate;
        }
        public void SetTitle(string Title)
        {
            title = Title;
        }
        public void SetPages(int Page)
        {
            pages = Page;
        }
        public void GetAll()
        {
            Console.Write(author);
            Console.Write(category);
            Console.Write(title);
            Console.WriteLine(releaseDate);
            Console.Write(pages);
        }
    }
}
