using dotnet_rpg.Dtos.Character;
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
    public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> Get()
    {
        return Ok(await _characterService.GetAllCharacters());
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ServiceResponse<GetCharacterDto>>> GetSingle(int id)
    {
        return Ok(await _characterService.GetCharacterById(id));
    }

    [HttpPost]
    public async Task<ActionResult<ServiceResponse<List<GetCharacterDto>>>> CreateCharacter(Character newCharacter)
    {
        return Ok(await _characterService.CreateCharacter(newCharacter));
    }

}