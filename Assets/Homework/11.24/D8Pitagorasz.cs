
using UnityEngine;

public class D8Pitagorasz : MonoBehaviour
{
    [SerializeField] int a, b, c;
    [SerializeField] bool isPythagorean;

    void OnValidate()
    {
        isPythagorean = IsPythagorean(a, b, c);
    }

    // Lényegi megoldás: 
    bool IsPythagorean(int a, int b, int c)
    {
        float hypotenuse = Mathf.Max(a, b, c);       // Átfogó
        float leg1 = Mathf.Min(a, b, c);              // Egyik befogó
        float leg2 = a + b + c - hypotenuse - leg1; // Másik befogó

        // Pihagorasz tétel alkalmazása:
        return leg1 * leg1 + leg2 * leg2 == hypotenuse * hypotenuse;
    }
}
