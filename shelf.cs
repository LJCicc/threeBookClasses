using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_triple_class
{
    enum Genre
    {
        // may or may not add/delete some of these (TBD)
        Horror,
        Romance,
        Fantasy,
        ScienceFiction,
        Mystery,
        Thriller,
        Nonfiction,
        Dystopia
    }
    class shelf
    {
        public Genre thisGenre;
        public author thisAuthor;

        // book list
        public List<book> booksOnShelf;

        public shelf()
        {
            booksOnShelf = new List<book>(); // !!!!!!!
        }
        
    }
}
