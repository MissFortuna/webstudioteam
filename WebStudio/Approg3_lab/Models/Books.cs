using System;
using System.Collections.Generic;
using System.Linq;

namespace Approg3_lab.Models
{
    public class Books
    {
        public List<BookModels> booksList = new List<BookModels>();
        public Books()
        {
            booksList.Add(new BookModels
            {
                Id = 1,
                Name = "Book1",
                Publishing = "Publish1",
                Author = "First name",
                Edition = 1
            });

            booksList.Add(new BookModels
            {
                Id = 2,
                Name = "Book2",
                Publishing = "Publish2",
                Author = "Second name",
                Edition = 1
            });
        }

        public void CreateBook(BookModels book)
        {
            try
            {
                int maxId = booksList.Count == 0 ? 0 : booksList.Select(item => item.Id).Max();
                book.Id = maxId + 1;
                booksList.Add(book);
            }
            catch (Exception)
            { }
        }

        public void UpdateBook(BookModels book)
        {
            try
            {
                //foreach (BookModels bm in booksList)
                //{
                //    if (bm.Id == bookModel.Id)
                //    {
                //        booksList.Remove(bm);
                //        booksList.Add(bookModel);
                //        break;
                //    }
                //}
                BookModels bm = booksList.Find(item => item.Id == book.Id);
                    bm.Name = book.Name;
                    bm.Publishing = book.Publishing;
                    bm.Author = book.Author;
                    bm.Edition = book.Edition;
            }
            catch (Exception)
            {
            }
        }

        //Advanced task
        public BookModels ShowBook(int Id)
        {
            return booksList.Find(item => item.Id == Id);
        }

        public void DeleteBook(int Id)
        {
            try
            {
                    booksList.Remove(booksList.Find(item => item.Id == Id));
            }
            catch (Exception)
            {
            }          
        }
    }
}