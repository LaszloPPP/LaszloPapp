using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fibonacci : MonoBehaviour
{
    [SerializeField] int n;

    private void OnValidate()
    {
        int[] fibo = new int[n];
        fibo[0] = 0;
        fibo[1] = 1;
        for (int i = 2; i < n; i++)
        {
            int sum = fibo[i-1]+fibo[i-2];
            fibo[i] = sum;
            Debug.Log("Fibo: "+ fibo[i]);
        }
    }
}
