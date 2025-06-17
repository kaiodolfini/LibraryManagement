using LibraryManagement.Communication.Requests;
using LibraryManagement.Communication.Responses;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BookController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterBookJson), StatusCodes.Status201Created)]
    public IActionResult Create([FromBody] RequestRegisterBookJson request)
    {
        var response = new ResponseRegisterBookJson
        {
            Id = Guid.NewGuid(),
            Title = request.Title,
                Author = request.Author,
                Genre = request.Genre,
                Price = request.Price,
                StockQuantity = request.StockQuantity
        };

        return Created($"api/book/{response.Id}", response);
    }

    [HttpGet]
    [ProducesResponseType(typeof(List<Book>), StatusCodes.Status200OK)]
    public IActionResult GetAll()
    {
        var response = new List<Book>()
        {
            new Book {
                    Id = Guid.NewGuid(),
                    Title = "Chapeuzinho Vermelho",
                    Author = "Charles Perrault",
                    Genre = (BookGenre)4,
                    Price = 23.78f,
                    StockQuantity = 3
            },
             new Book {
                    Id = Guid.NewGuid(),
                    Title = "Cinderela",
                    Author = "Charles Perrault",
                    Genre = (BookGenre)4,
                    Price = 12.64f,
                    StockQuantity = 12
             }
        };

        return Ok(response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Update([FromRoute] Guid id, [FromBody] RequestUpdateBookJson request)
    {
        return NoContent();
    }

    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult Delete([FromRoute] Guid id)
    {
        return NoContent();
    }
}
