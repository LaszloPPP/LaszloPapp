using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class megforditas : MonoBehaviour
{
    [SerializeField] int[] array;
    

    private void Start()
    {
        for (int i = array.Length-1; i >=0; i--)
        {
            Debug.Log(array[i]);
        }
        
    }
}
