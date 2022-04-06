using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using my_book_api.Data.ViewModels;
using my_book_api.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace my_book_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        public BookServices _bookservice;
        public BooksController(BookServices bookservice)
        {
            _bookservice = bookservice; 
        }

        [HttpPost("add-book")]
        public ActionResult AddBook([FromBody] BookVM book)
        {
            _bookservice.AddBook(book);

            return Ok();
        }
        [HttpGet("get-all-books")]
        public IActionResult getallbooks()
        {
            var allbooks = _bookservice.GetAllBooks();
            return Ok(allbooks);
        }
        [HttpGet("get-book-byId/{bookid}")]
        public IActionResult getbookbyId(int bookid)
        {
            var book = _bookservice.Getbookby_Id(bookid);
            return Ok(book);
        }
        [HttpPut("Update-book-byID/{bookid}")]
        public IActionResult updatebook(int bookid,[FromBody]BookVM bookvm)
        {
            var updatedbook = _bookservice.UpdateBookbyId(bookid,bookvm);
            return Ok(updatedbook);
        }
        [HttpDelete("Delete-book-byId")]
        public IActionResult Deletebook(int id)
        {
           _bookservice.DeleteBookbyID(id);
            return Ok();
        }
    }
}
