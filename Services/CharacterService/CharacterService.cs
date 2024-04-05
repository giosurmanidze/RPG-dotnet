using dotnet_rpg.Entities;

namespace dotnet_rpg.Services.CharacterService;

public class CharacterService : ICharacterService
{
     private static List<Character> characters = new List<Character> {
        new Character(),
        new Character{Id = 1, Name = "gioooo" }
     };


    public async Task<ServiceResponse<List<Character>>> CreateCharacter(Character newCharacter)
    {
        var serviceResponse = new ServiceResponse<List<Character>>();
        characters.Add(newCharacter);
        serviceResponse.Data = characters;
        return serviceResponse;
    }

    public async Task<ServiceResponse<List<Character>>> GetAllCharacters()
    {
        var serviceResponse = new ServiceResponse<List<Character>>();
        serviceResponse.Data = characters;
        return serviceResponse;
    }

    public async Task<ServiceResponse<Character>> GetCharacterById(int id)
    {
         var serviceResponse = new ServiceResponse<Character>();
         var character = characters.FirstOrDefault(c => c.Id == id);
         serviceResponse.Data = character;
         return serviceResponse;
    }
}