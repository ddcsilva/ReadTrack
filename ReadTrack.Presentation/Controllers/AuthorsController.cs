using Microsoft.AspNetCore.Mvc;
using ReadTrack.Service.Contracts;

namespace ReadTrack.Presentation.Controllers;

[Route("api/authors")]
[ApiController]
public class AuthorsController : ControllerBase
{
    private readonly IServiceManager _service;

    public AuthorsController(IServiceManager service) => _service = service;

    [HttpGet]
    public IActionResult GetAuthors()
    {
        try
        {
            var authors = _service.AuthorService.GetAllAuthors(trackChanges: false);
            return Ok(authors);
        }
        catch
        {
            return StatusCode(500, "Erro interno no servidor.");
        }
    }

    [HttpGet("test-exception")]
    public IActionResult TestException()
    {
        throw new Exception("Erro proposital pra testar o middleware global.");
    }

}
