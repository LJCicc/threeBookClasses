using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_triple_class
{

    class book
    {
        private string bookTitle;
        private author bookAuthor;
        private int pageNumber;
        public string bookType;
        public string BookTitle { get => bookTitle; set => bookTitle = value; }
        public author BookAuthor { get => bookAuthor; set => bookAuthor = value; }
        public int PageNumber { get => pageNumber; set => pageNumber = value; }
        public string BookType { get => bookType; set => bookType = value; }
    }
}
