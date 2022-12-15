using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class osszeskulonbozobetu : MonoBehaviour
{
    // Tesztelésre:
    [SerializeField]
    string text =
        "Megszentségteleníthetetlenségeskedéseitekért";
    [Space]
    [SerializeField] int uniqCharacterCount;

    void OnValidate()
    {
        uniqCharacterCount = CountUniqCharacters(text);
    }

    // Lényegi megoldás: 
    int CountUniqCharacters(string s)
    {
        // Egyedi karaktereket tertalmazó tömb
        List<char> characters = new List<char>();
        foreach (char c in s) // minden karaktert megnézünk
        {
            if (!characters.Contains(c))
                characters.Add(c);
        }

        return characters.Count;
    }
}
