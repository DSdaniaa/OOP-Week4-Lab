using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.BL
{
    class book
    {
        public string author;
        public int pages;
        public List<string> Chapters = new List<string>();
        public int bookMark;
        public int price;
        public book(string auth, int page, int book, int pri )
        {
            author = auth;
            pages = page;
            bookMark = book;
            price = pri;

        }
        public void addChapters(string name)
        {
            Chapters.Add(name);
        }
        public string getChapter(int chapterNumber)
        {
            return Chapters[chapterNumber - 1];
        }
        public int getBookMark()
        {
            return bookMark;
        }
        public void setBookMark(int pageNumber)
        {
            bookMark = pageNumber;
        }
        public int getBookPrice()
        {
            return price;
        }
        public void setBookPrice(int newPrice)
        {
            price = newPrice;
        }
    }
}
