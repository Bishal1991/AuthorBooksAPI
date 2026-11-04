using Microsoft.AspNetCore.Mvc;
using AuthorBooksAPI.Application.Interfaces;

namespace AuthorBooksAPI.Controllers
{
    [Route ("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService; 
        }

        [HttpGet]

        public async Task<IActionResult> GetAll() 
        {
            var books = await _bookService.GetAllAsync();
            return Ok(books);
        }
    }
}
