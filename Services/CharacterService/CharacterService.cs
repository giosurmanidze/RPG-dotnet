using dotnet_rpg.Dtos.Character;
using dotnet_rpg.Entities;

namespace dotnet_rpg.Services.CharacterService;

public class CharacterService : ICharacterService
{
     private static List<Character> characters = new List<Character> {
        new Character(),
        new Character{Id = 1, Name = "gioooo" }
     };


    public async Task<ServiceResponse<List<GetCharacterDto>>> CreateCharacter(AddCharacterDto newCharacter)
    {
        var serviceResponse = new ServiceResponse<List<GetCharacterDto>>();
        characters.Add(newCharacter);
        serviceResponse.Data = characters;
        return serviceResponse;
    }

    public async Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters()
    {
        var serviceResponse = new ServiceResponse<List<GetCharacterDto>>();
        serviceResponse.Data = characters;
        return serviceResponse;
    }

    public async Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id)
    {
         var serviceResponse = new ServiceResponse<GetCharacterDto>();
         var character = characters.FirstOrDefault(c => c.Id == id);
         serviceResponse.Data = character;
         return serviceResponse;
    }
}