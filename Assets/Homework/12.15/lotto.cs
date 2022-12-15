using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lotto : MonoBehaviour
{
    [SerializeField] int[] winningNumbers;

    void Start()
    {
        winningNumbers = Lottery(90, 5);
    }

    // L�nyegi megold�s:
    int[] Lottery(int allNumbers, int chosenNumbers)
    {
        // �sszes sz�m list�ja:
        List<int> allNumbersList = new List<int>();
        for (int i = 1; i <= allNumbers; i++)
            allNumbersList.Add(i);

        // Nyert sz�mok t�mbje:
        int[] lottery = new int[chosenNumbers];

        // V�letlen sz�mok kiv�laszt�sa:
        for (int i = 0; i < chosenNumbers; i++)
        {
            int randomIndex = Random.Range(0, allNumbersList.Count);
            lottery[i] = allNumbersList[randomIndex];

            // Ha egy sz�mot m�r kisorsol, akkor azt kivessz�k a list�b�l:
            allNumbersList.RemoveAt(randomIndex);
        }
        return lottery;
    }
}
