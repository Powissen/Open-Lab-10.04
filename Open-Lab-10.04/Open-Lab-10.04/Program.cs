using System;

namespace Open_Lab_10._03
{
    class Program
    {
        static void Main(string[] args)
        {
            Book LOTR = new Book();
            //LOTR.title = "Title";    
            //Console.WriteLine(LOTR.title);
            LOTR.Title("Title");
            LOTR.Pages(50);
            LOTR.Category("Category");
            LOTR.Author("Author");
            LOTR.ReleaseDate(2020);
            Console.WriteLine(LOTR.ToString());
        }
    }
    
    
    public class Book
    {
        public string title;
        public int pages;
        public string category;
        public string author;
        public int releaseDate;

        public void Title(string NewTitle) 
        { 
            title = NewTitle;
        }
        public void Pages(int NewPages) 
        {
            pages = NewPages; 
            if (pages < 0)
            {
                pages = 1;
            }
        }
        public void Category(string NewCategory) 
        { 
            category = NewCategory;
        }
        public void Author(string NewAuthor) 
        { 
            author = NewAuthor;
        }
        public void ReleaseDate(int NewReleaseDate) 
        { 
            releaseDate = NewReleaseDate;
            if (releaseDate < 1450 || releaseDate > 2021)
            {
                releaseDate = -1;
            }
        }


        public override string ToString()
        {
            string output = title + pages + category + author + releaseDate;
            return output;
        }
    }
}