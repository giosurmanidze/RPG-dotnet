using dotnet_rpg.Entities;

namespace dotnet_rpg.Services.CharacterService;

public interface ICharacterService
{
    List<Character> GetAllCharacters();
    Character GetCharacterById(int id);
    List<Character> CreateCharacter(Character newCharacer);

}