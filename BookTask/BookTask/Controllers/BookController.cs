using BookTask.Entity;
using BookTask.Migrations;
using BookTask.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using static System.Reflection.Metadata.BlobBuilder;

namespace BookTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookServices BookServices;
        public BookController()
        {
            BookServices = new BookServices();
        }
        [HttpGet, Route("Getallbooks")]
        public IActionResult GetAll()
        {
            try
            {
                List<Entity.Book> book = BookServices.GetBooks();

                return StatusCode(200, book);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }




        [HttpGet, Route("GetbookbyAuthor")]
        public IActionResult Get(string author)
        {
            try
            {
                List<Entity.Book> book = BookServices.GetBookByAuthor(author);
                return StatusCode(200, book);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet, Route("GetBookByLanguage")]
        public IActionResult Getbook(string lang)
        {
            try
            {
                List<Entity.Book> books = BookServices.GetBookByLanguage(lang);
                return Ok(books);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost, Route("Books")]
        public IActionResult Add(Entity.Book book)
        {
            try
            {
                BookServices.AddBook(book);
                return StatusCode(200, book);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex);
            }
        }
        [HttpGet, Route("GetBookByyear")]
        public IActionResult Get(DateTime year)
        {
            try
            {
                List<Entity.Book> book = BookServices.GetBookByyear(year);
                return StatusCode(200, book);
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex);
            }

        }
        [HttpDelete, Route("Deletebookbyid/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                BookServices.DeleteBook(id);
                return StatusCode(200, new JsonResult($"Book with Id {id} is Deleted"));
            }
            catch (Exception ex)
            {

                return StatusCode(500, ex);
            }
        }
        [HttpPut, Route("Updatebook")]
        public IActionResult Edit(Entity.Book book)
        {

            try
            {
                BookServices.UpdateBook(book);
                return StatusCode(200, book);

            }
            catch (Exception ex)
            {

                return StatusCode(500, ex);
            }

        }
    }
} 

