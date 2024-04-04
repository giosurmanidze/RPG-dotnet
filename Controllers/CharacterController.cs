using dotnet_rpg.Entities;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CharacterController : ControllerBase
{
     private static List<Character> characters = new List<Character> {
        new Character(),
        new Character{ Name = "giusha" }
     };


    [HttpGet("getAll")]
    // [Route("getAll")]
    public ActionResult<List<Character>> Get()
    {
        return Ok(characters);
    }

    [HttpGet("getSingle")]
    // [Route("getSingle")]
    public ActionResult<Character> GetSingle()
    {
        return Ok(characters[0]);
    }

}