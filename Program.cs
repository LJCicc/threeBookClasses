using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_triple_class
{
    class Program
    {
        static void Main(string[] args)
        {
            bool browsing = true;

            // 1st author initialized
            author King = new author();
            King.AuthorLastName = "King";
            
            // 1st book on shelf
            book hb1 = new book();
            hb1.BookAuthor = King;
            hb1.BookTitle = "The Shining";
            hb1.PageNumber = 447;
            hb1.bookType = "Novel";

            // 2nd book on shelf
            book hb2 = new book();
            hb2.BookAuthor = King;
            hb2.BookTitle = "Misery";
            hb2.PageNumber = 432;
            hb2.bookType = "Novel";

            // 3rd book on shelf
            book hb3 = new book();
            hb3.BookAuthor = King;
            hb3.BookTitle = "Christine";
            hb3.PageNumber = 526;
            hb3.bookType = "Novel";

            // new shelf initialized
            shelf scary = new shelf();

            // adding books to shelf
            scary.thisAuthor = King;
            scary.thisGenre = Genre.Horror;
            scary.booksOnShelf.Add(hb1);
            scary.booksOnShelf.Add(hb2);
            scary.booksOnShelf.Add(hb3);

            // 2nd author initialized
            author Rowling = new author();
            Rowling.AuthorLastName = "Rowling";

            // 1st book on shelf
            book fb1 = new book();
            fb1.BookAuthor = Rowling;
            fb1.BookTitle = "Harry Potter and the Philospher's Stone";
            fb1.PageNumber = 223;
            fb1.bookType = "Series";

            // 2nd book on shelf
            book fb2 = new book();
            fb2.BookAuthor = Rowling;
            fb2.BookTitle = "Harry Potter and the Chamber of Secrets";
            fb2.PageNumber = 251;
            fb2.bookType = "Series";

            // 3rd book on shelf
            book fb3 = new book();
            fb3.BookAuthor = Rowling;
            fb3.BookTitle = "Harry Potter and the Prisoner of Azkaban";
            fb3.PageNumber = 317;
            fb3.bookType = "Series";

            // 4th book on shelf
            book fb4 = new book();
            fb4.BookAuthor = Rowling;
            fb4.BookTitle = "Harry Potter and the Goblet of Fire";
            fb4.PageNumber = 636;
            fb4.bookType = "Series";

            // 5th book on shelf
            book fb5 = new book();
            fb5.BookAuthor = Rowling;
            fb5.BookTitle = "Harry Potter and the Order of the Phoenix";
            fb5.PageNumber = 766;
            fb5.bookType = "Series";

            // 6th book on shelf
            book fb6 = new book();
            fb6.BookAuthor = Rowling;
            fb6.BookTitle = "Harry Potter and the Half Blood Prince";
            fb6.PageNumber = 607;
            fb6.bookType = "Series";

            // 7th book on shelf
            book fb7 = new book();
            fb7.BookAuthor = Rowling;
            fb7.BookTitle = "Harry Potter and the Deathly Hallows";
            fb7.PageNumber = 607;
            fb7.bookType = "Series";

            // new shelf initialized
            shelf magic = new shelf();
            magic.thisAuthor = Rowling;

            // adding books to shelf
            magic.thisGenre = Genre.Fantasy;
            magic.booksOnShelf.Add(fb1);
            magic.booksOnShelf.Add(fb2);
            magic.booksOnShelf.Add(fb3);
            magic.booksOnShelf.Add(fb4);
            magic.booksOnShelf.Add(fb5);
            magic.booksOnShelf.Add(fb6);
            magic.booksOnShelf.Add(fb7);

            while(browsing == true) // loops the options
            {
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("1. Add a book");
                Console.WriteLine("2. View shelves");
                Console.WriteLine("3. Exit Library");
                int browsingAns = Convert.ToInt32(Console.ReadLine());

                if(browsingAns == 1)
                {
                    book userBook = new book();
                    Console.WriteLine("What is the name of the book?");
                    string userBookName = Convert.ToString(Console.ReadLine());
                    userBook.BookTitle = userBookName;

                    Console.WriteLine("Who is the author?");
                    author userAuthor = new author();
                    string userAuthorName = Convert.ToString(Console.ReadLine());
                    userAuthor.AuthorLastName = userAuthorName;

                    Console.WriteLine("How many pages are in it?");
                    int userBookPage = Convert.ToInt32(Console.ReadLine());
                    userBook.PageNumber = userBookPage;

                    Console.WriteLine("What type of book is it?");
                    string userBookType = Convert.ToString(Console.ReadLine());
                    userBook.BookType = userBookType;


                    Console.WriteLine("Which shelf is it going to go on?");
                    Console.WriteLine("1. Scary");
                    Console.WriteLine("2. Magic");
                    int shelfAdd = Convert.ToInt32(Console.ReadLine());
                    if(shelfAdd == 1)
                    {
                        if(userBookName == hb1.BookTitle || userBookName == hb2.BookTitle || userBookName == hb3.BookTitle)
                        {
                            Console.WriteLine("That book already exists on this shelf.");
                            browsing = false;
                        }
                        else
                        {
                            scary.booksOnShelf.Add(userBook);
                            Console.WriteLine("Your book has been added to the scary shelf.");
                            Console.WriteLine("Here are all of the books on this shelf: ");
                            Console.WriteLine("1. {0}", hb1.BookTitle);
                            Console.WriteLine("2. {0}", hb2.BookTitle);
                            Console.WriteLine("3. {0}", hb3.BookTitle);
                            Console.WriteLine("4. {0}", userBook.BookTitle);
                        }
                        
                    }
                    else if(shelfAdd == 2)
                    {
                        // might break this up
                        // too many qualifiers

                        if (userBookName == fb1.BookTitle || userBookName == fb2.BookTitle || userBookName == fb3.BookTitle || userBookName == fb4.BookTitle || userBookName == fb5.BookTitle || userBookName == fb6.BookTitle || userBookName == fb7.BookTitle)
                        {
                            Console.WriteLine("That book already exists on this shelf.");
                            browsing = false;
                        }
                        else
                        {
                            magic.booksOnShelf.Add(userBook);
                            Console.WriteLine("Your book has been added to the magic shelf.");

                            Console.WriteLine("Here are the books on this shelf: ");
                            Console.WriteLine("1. {0}", fb1.BookTitle);
                            Console.WriteLine("2. {0}", fb2.BookTitle);
                            Console.WriteLine("3. {0}", fb3.BookTitle);
                            Console.WriteLine("4. {0}", fb4.BookTitle);
                            Console.WriteLine("5. {0}", fb5.BookTitle);
                            Console.WriteLine("6. {0}", fb6.BookTitle);
                            Console.WriteLine("7. {0}", fb7.BookTitle);
                            Console.WriteLine("4. {0}", userBook.BookTitle);
                        }
                    }

                }
                else if(browsingAns == 2)
                {
                    Console.WriteLine("Which shelf would you like to view?");
                    string shelfAns = Convert.ToString(Console.ReadLine());

                    if (shelfAns.ToUpper() == "SCARY")
                    {
                        Console.WriteLine("Here are the books on this shelf: ");
                        Console.WriteLine("1. {0}", hb1.BookTitle);
                        Console.WriteLine("2. {0}", hb2.BookTitle);
                        Console.WriteLine("3. {0}", hb3.BookTitle);

                        Console.WriteLine("Which book would you like to look at?");
                        int bookAns = Convert.ToInt32(Console.ReadLine());
                        switch (bookAns)
                        {
                            case 1:
                                Console.WriteLine("The author is: {0}", King.AuthorLastName);
                                Console.WriteLine("The genre is: {0}", scary.thisGenre);
                                Console.WriteLine("It is a: {0}", hb1.BookType);
                                Console.WriteLine("It has {0} pages", hb1.PageNumber);
                                break;
                            case 2:
                                Console.WriteLine("The author is: {0}", King.AuthorLastName);
                                Console.WriteLine("The genre is: {0}", scary.thisGenre);
                                Console.WriteLine("It is a: {0}", hb2.BookType);
                                Console.WriteLine("It has {0} pages", hb2.PageNumber);
                                break;
                            case 3:
                                Console.WriteLine("The author is: {0}", King.AuthorLastName);
                                Console.WriteLine("The genre is: {0}", scary.thisGenre);
                                Console.WriteLine("It is a: {0}", hb3.BookType);
                                Console.WriteLine("It has {0} pages", hb3.PageNumber);
                                break;
                        }
                    }
                    else if (shelfAns.ToUpper() == "MAGIC")
                    {
                        Console.WriteLine("Here are the books on this shelf: ");
                        Console.WriteLine("1. {0}", fb1.BookTitle);
                        Console.WriteLine("2. {0}", fb2.BookTitle);
                        Console.WriteLine("3. {0}", fb3.BookTitle);
                        Console.WriteLine("4. {0}", fb4.BookTitle);
                        Console.WriteLine("5. {0}", fb5.BookTitle);
                        Console.WriteLine("6. {0}", fb6.BookTitle);
                        Console.WriteLine("7. {0}", fb7.BookTitle);

                        Console.WriteLine("Which book would you like to look at?");
                        int bookAns = Convert.ToInt32(Console.ReadLine());
                        switch (bookAns)
                        {
                            case 1:
                                Console.WriteLine("The author is: {0}", Rowling.AuthorLastName);
                                Console.WriteLine("The genre is: {0}", magic.thisGenre);
                                Console.WriteLine("It is a: {0}", fb1.BookType);
                                Console.WriteLine("It has {0} pages", fb1.PageNumber);
                                break;
                            case 2:
                                Console.WriteLine("The author is: {0}", Rowling.AuthorLastName);
                                Console.WriteLine("The genre is: {0}", magic.thisGenre);
                                Console.WriteLine("It is a: {0}", fb2.BookType);
                                Console.WriteLine("It has {0} pages", fb2.PageNumber);
                                break;
                            case 3:
                                Console.WriteLine("The author is: {0}", Rowling.AuthorLastName);
                                Console.WriteLine("The genre is: {0}", magic.thisGenre);
                                Console.WriteLine("It is a: {0}", fb3.BookType);
                                Console.WriteLine("It has {0} pages", fb3.PageNumber);
                                break;
                            case 4:
                                Console.WriteLine("The author is: {0}", Rowling.AuthorLastName);
                                Console.WriteLine("The genre is: {0}", magic.thisGenre);
                                Console.WriteLine("It is a: {0}", fb4.BookType);
                                Console.WriteLine("It has {0} pages", fb4.PageNumber);
                                break;
                            case 5:
                                Console.WriteLine("The author is: {0}", Rowling.AuthorLastName);
                                Console.WriteLine("The genre is: {0}", magic.thisGenre);
                                Console.WriteLine("It is a: {0}", fb5.BookType);
                                Console.WriteLine("It has {0} pages", fb5.PageNumber);
                                break;
                            case 6:
                                Console.WriteLine("The author is: {0}", Rowling.AuthorLastName);
                                Console.WriteLine("The genre is: {0}", magic.thisGenre);
                                Console.WriteLine("It is a: {0}", fb6.BookType);
                                Console.WriteLine("It has {0} pages", fb6.PageNumber);
                                break;
                            case 7:
                                Console.WriteLine("The author is: {0}", Rowling.AuthorLastName);
                                Console.WriteLine("The genre is: {0}", magic.thisGenre);
                                Console.WriteLine("It is a: {0}", fb7.BookType);
                                Console.WriteLine("It has {0} pages", fb7.PageNumber);
                                break;
                        }
                    }
                }
                else if(browsingAns == 3)
                {
                    Console.WriteLine("Bye!");
                    browsing = false;
                }
            }

            Console.ReadLine();
        }
    }
}
