using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using PioneerOnlineLibrary.Domain.Model;
using PioneerOnlineLibrary.Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PioneerOnlineLibrary.Infrastructure.Repository
{
    public class BookRepository :IBookRepository, IAuthorizationRequirement
    {
        private readonly PioneerDbContext _context;
        public BookRepository(PioneerDbContext context)
        {
            _context = context;
        }

        public BookRepository()
        {
        }

        public List<Book> AllBookList()
        {
            var books = _context.Books.ToList();
            return books;
        }

        public Book CreateBook(Book book)
        {
            var books = new Book
            {
                Title = book.Title,
                Author = book.Author,
                ISBN = book.ISBN,
                Pages = book.Pages,
                Price = book.Price,
                Genre = book.Genre,
                BookCategory = book.BookCategory,
                ImageURL = book.ImageURL,
                Publisher= book.Publisher,
                Language= book.Language,
                Description= book.Description,
            };
            _context.Add(books);
            _context.SaveChanges();
            return books;
        }

        public Book DeleteBook(string ISBN)
        {
          
            var result = _context.Books.FirstOrDefault(x => x.ISBN == ISBN);
            if (result != null)
            {
                _context.Books.Remove(result);
                _context.SaveChanges();
                return result;
            }

            return null!;
        }


        public Book UpdateBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
            return book;
        }
        public Book GetBookByAuthor(string author)
        {
            var book = _context.Books.FirstOrDefault(x => x.Author == author);
            return book!;
        }
        public Book GetBookByYearPublished(string yearPublished)
        {
            var book = _context.Books.FirstOrDefault(x => x.PublicationDate == yearPublished);
            return book!;
        }
        public Book GetBookByISBN(string ISBN)
        {
            var book = _context.Books.FirstOrDefault(x => x.ISBN == ISBN);
            return book!;
        }

        public Book GetBookByPublisher(string publisher)
        {
            var book = _context.Books.FirstOrDefault(x => x.Publisher == publisher);
            return book!;
        }
        public Book GetBookByTitle(string title)
        {
            var book = _context.Books.FirstOrDefault(x => x.Title == title);
            return book!;
        }

    }
}
