using UnityEngine;
using System.Collections;

public static class Character {
    
    public static CharacterControllerScript character = null;

    public static CharacterControllerScript getCharacter()
    {
        if (Character.character == null) {
            Character.character = GameObject.Find("Character 1").GetComponent<CharacterControllerScript>();
        }

        return Character.character;
    }
}
