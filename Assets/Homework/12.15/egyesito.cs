using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class egyesito : MonoBehaviour
{
    // Tesztelésre:
    [SerializeField] string[] a = Array.Empty<string>();
    [SerializeField] string[] b = Array.Empty<string>();
    [SerializeField] string[] combined;

    void OnValidate()
    {
        combined = Combine(a, b);
    }

    // Lényegi megoldás:
    string[] Combine(string[] a1, string[] a2)
    {
        string[] c = new string[a1.Length + a2.Length];

        for (int i = 0; i < a1.Length; i++)
            c[i] = a1[i];

        for (int i = 0; i < a2.Length; i++)
            c[a1.Length + i] = a2[i];

        return c;
    }
}
