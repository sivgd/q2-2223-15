using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterManager : MonoBehaviour
{
    public static CharacterManager instance;
    public RectTransform characterPanel;
    public List<Character> characters = new List<Character>();
    public Dictionary<string, int> characterDictionary = new Dictionary<string, int>();

    void Awake()
    {
        instance = this;
    }

    public Character GetCharacter(string characterName, bool createCharacterIfDoesNotExist = true)
    {
        int index = -1;
        if (characterDictionary.TryGetValue (characterName, out index))
        {
            return characters [index];
        }
        else if (createCharacterIfDoesNotExist)
        {
            return createCharacter (characterName);
        }

        return null;
    }

    public void CreateCharacter(string characterName)
    {
        Character newCharacter = new Character(characterName);

        characterDictionary.Add(characterName, characters.Count);
        characters.Add(newCharacter);

        return newCharacter;
    }
}
