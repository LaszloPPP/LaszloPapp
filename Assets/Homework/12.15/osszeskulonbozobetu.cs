using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class osszeskulonbozobetu : MonoBehaviour
{
    // Tesztel�sre:
    [SerializeField]
    string text =
        "Megszents�gtelen�thetetlens�gesked�seitek�rt";
    [Space]
    [SerializeField] int uniqCharacterCount;

    void OnValidate()
    {
        uniqCharacterCount = CountUniqCharacters(text);
    }

    // L�nyegi megold�s: 
    int CountUniqCharacters(string s)
    {
        // Egyedi karaktereket tertalmaz� t�mb
        List<char> characters = new List<char>();
        foreach (char c in s) // minden karaktert megn�z�nk
        {
            if (!characters.Contains(c))
                characters.Add(c);
        }

        return characters.Count;
    }
}
