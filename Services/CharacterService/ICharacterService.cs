using dotnet_rpg.Entities;

namespace dotnet_rpg.Services.CharacterService;

public interface ICharacterService
{
    Task<List<Character>> GetAllCharacters();
    Task<Character> GetCharacterById(int id);
    Task<List<Character>> CreateCharacter(Character newCharacer);

}