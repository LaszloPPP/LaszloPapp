using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minmaxtombon : MonoBehaviour
{
    /*[SerializeField] float[] myArray;
    [SerializeField] float min, max;

    private void OnValidate()
    {

        /*if (myArray.Length > 0)
        {
            float min = myArray[0];
            float max = myArray[0];
            for (int i = 0; i < myArray.Length; i++)
            {
                if (max < myArray[i])
                {
                    float tmp = max;
                    max = myArray[i];
                    myArray[i] = max;
                }
                if (min > myArray[i])
                {
                    float tmp = min;
                    min = myArray[i];
                    myArray[i] = min;
                }
            }
        }
        */
    [SerializeField] float[] values = Array.Empty<float>();
    [Space]
    [SerializeField] float minimum;
    [SerializeField] float maximum;

    void OnValidate()
    {
        minimum = Min(values);
        maximum = Max(values);
    }

    // Lényegi megoldás:

    // Minimum keresõ függvény float-okon
    float Min(float[] array)
    {
        if (array == null || array.Length == 0)
            return 0;

        float min = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] < min)
                min = array[i];
        }
        return min;
    }

    // Maximum keresõ függvény float-okon
    float Max(float[] array)
    {
        if (array == null || array.Length == 0)
            return 0;

        float max = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
                max = array[i];
        }
        return max;
    }
}
