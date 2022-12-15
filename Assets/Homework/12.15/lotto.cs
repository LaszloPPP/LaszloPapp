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

    // Lényegi megoldás:
    int[] Lottery(int allNumbers, int chosenNumbers)
    {
        // Összes szám listája:
        List<int> allNumbersList = new List<int>();
        for (int i = 1; i <= allNumbers; i++)
            allNumbersList.Add(i);

        // Nyert számok tömbje:
        int[] lottery = new int[chosenNumbers];

        // Véletlen számok kiválasztása:
        for (int i = 0; i < chosenNumbers; i++)
        {
            int randomIndex = Random.Range(0, allNumbersList.Count);
            lottery[i] = allNumbersList[randomIndex];

            // Ha egy számot már kisorsol, akkor azt kivesszük a listából:
            allNumbersList.RemoveAt(randomIndex);
        }
        return lottery;
    }
}
