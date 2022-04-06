using my_book_api.Data;
using my_book_api.Data.Models;
using my_book_api.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_book_api.Services
{
    public class BookServices
    {
        private AppDbcontext  _context;
        public BookServices(AppDbcontext context)
        {
            _context = context;
        }
        public void AddBook(BookVM book)
        {
            var _Book = new Book()
            {
                Title = book.Title,
                Description = book.Description,
                Isread = book.Isread,
                DateRead = book.Isread ? book.DateRead.Value : null,
                Rate = book.Isread ? book.Rate.Value : null,
                Genre = book.Genre,
                Author = book.Author,
                Coverurl = book.Coverurl,
                DateAdded = DateTime.Now

            };

            _context.Books.Add(_Book);
            _context.SaveChanges();
        }

        public List<Book> GetAllBooks()
        {
            var books = _context.Books.ToList();
            return books;
        }

        public Book Getbookby_Id(int bookid)
        {
            var bookbyId = _context.Books.FirstOrDefault(x => x.Id == bookid);
            return bookbyId;
        }

        public Book UpdateBookbyId(int BookId , BookVM book)
        {
            var _book = _context.Books.FirstOrDefault(x => x.Id == BookId);
            if(_book != null)
            {
                _book.Title = book.Title;
                _book.Description = book.Description;
                _book.Isread = book.Isread;
                _book.DateRead = book.Isread ? book.DateRead.Value : null;
                _book.Rate = book.Isread ? book.Rate.Value : null;
                _book.Genre = book.Genre;
                _book.Author = book.Author;
                _book.Coverurl = book.Coverurl;

                _context.SaveChanges();
            }
            return _book;
        }

        public void DeleteBookbyID(int bookId)
        {
            var deletebook = _context.Books.FirstOrDefault(x => x.Id == bookId);

            if(deletebook != null)
            {
                _context.Books.Remove(deletebook);
                _context.SaveChanges();
            }
        }
    }
}
