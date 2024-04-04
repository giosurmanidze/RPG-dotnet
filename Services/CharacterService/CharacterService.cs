using dotnet_rpg.Entities;

namespace dotnet_rpg.Services.CharacterService;

public class CharacterService : ICharacterService
{
     private static List<Character> characters = new List<Character> {
        new Character(),
        new Character{Id = 1, Name = "gioooo" }
     };


    public List<Character> CreateCharacter(Character newCharacter)
    {
        characters.Add(newCharacter);
        return characters;
    }

    public List<Character> GetAllCharacters()
    {
        return characters;
    }

    public Character GetCharacterById(int id)
    {
        return characters.FirstOrDefault(c => c.Id == id);
    }
}