using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PioneerOnlineLibrary.Domain.Model;
using PioneerOnlineLibrary.Infrastructure.Interface;

namespace PioneerOnlineLibrary.API.Controllers
{
    [Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IBookRepository _books;

        public AdminController(IBookRepository book)
        {
            _books = book;    
        }

        [HttpGet("book")]
        public IEnumerable<Book> AllBookList()
        {
            var allBooks = _books.AllBookList();
            
            return allBooks;  
        }


        [HttpGet("get-book/ISBN")]
        public IActionResult GetBookByISBN(string ISBN)
        {
            var byIsbn = _books.GetBookByISBN(ISBN);
            return Ok(byIsbn);
        }



        [HttpPost("createbook")]
        public IActionResult CreateBook(Book book)
        {
            var Books = _books.CreateBook(book);
         
            return Ok(Books);
        }



        [HttpDelete("delete/ISBN")]
        public IActionResult DeleteBook([FromBody]string ISBN)
        {
            var dBooks = _books.DeleteBook(ISBN);
            return NoContent();
        }



        [HttpPut("update-book/{book}")]
        public IActionResult UpdateBook(Book book)
        {
            var updateBooks = _books.UpdateBook(book);
            return Ok(updateBooks);
        }

        
    }
}
