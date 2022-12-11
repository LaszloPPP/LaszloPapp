using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tombmatek : MonoBehaviour
{
    [SerializeField] float[] vars;
    [Header("Results")]
    [SerializeField] float sum;
    [SerializeField] float mult;
    [SerializeField] float avg;

    private void OnValidate()
    {
        /*float sum = 0;
        for (int i = 0; i < vars.Length; i++)
        {
            sum += vars[i];
        }
        


        /*float mult = 0;
        for (int i = 0; i < vars.Length; i++)
        {
            mult *= vars[i];
        }
        */
        sum = 0;
        mult = 1;
        for (int i = 0; i < vars.Length; i++)
        {
            sum += vars[i];
            mult *= vars[i];
        }

        avg = sum / vars.Length;
        
    }
}
