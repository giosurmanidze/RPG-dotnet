using dotnet_rpg.Entities;
using dotnet_rpg.Services.CharacterService;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CharacterController : ControllerBase
{

     public readonly ICharacterService _characterService;

     public CharacterController(ICharacterService characterService)
     {
        _characterService = characterService;
     }


    [HttpGet("getAll")]
    public ActionResult<List<Character>> Get()
    {
        return Ok(_characterService.GetAllCharacters());
    }

    [HttpGet("{id}")]
    public ActionResult<Character> GetSingle(int id)
    {
        return Ok(_characterService.GetCharacterById(id));
    }

    [HttpPost]
    public ActionResult<List<Character>> CreateCharacter(Character newCharacter)
    {
        return Ok(_characterService.CreateCharacter(newCharacter));
    }

}