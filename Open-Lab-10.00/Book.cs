using System;
using System.Collections.Generic;
using System.Text;


namespace Open_Lab_10._00
{
    class Book
    {
        private string category;
        private string author;
        private int releaseDate;
        private string title;
        private int pages;

        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        //public void SetCategory(string Category)
        //{
        //    category = Category;
        //}


        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        //public void SetAuthor(string Author)
        //{
        //    author = Author;
        //}


        public int ReleaseDate
        {
            get { return releaseDate; }
            set
            {
                if (value >= 1450 && value <= 2021)
                {
                    releaseDate = value;
                }
                else
                {
                    releaseDate = -1;
                }
            }
            
        }
        //public void SetReleaseDate(int ReleaseDate)
        //{
        //    releaseDate = ReleaseDate;
        //}


        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        //public void SetTitle(string Title)
        //{
        //    title = Title;
        //}



        public int Pages
        {
                get 
                { 
                    return pages;
                }
            set
            {
                if (value > 0)
                {
                    pages = value;
                }
                else
                {
                    pages = 1;
                }
            }
        }
        //public void SetPages(int Page)
        //{
        //    pages = Page;
        //}
        //public void GetAll()
        //{
        //    Console.Write(author);
        //    Console.Write(category);
        //    Console.Write(title);
        //    Console.Write(releaseDate);
        //    Console.Write(pages);
        //}
    }
}
