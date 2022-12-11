using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tombfeltoltes : MonoBehaviour
{
    [SerializeField] int number;
    [SerializeField] int[] numArray;

    private void OnValidate()
    {
        numArray = new int[number];
        for (int i = 0; i <= number; i++)
        {
            numArray[i]= i;
        }
    }
}
