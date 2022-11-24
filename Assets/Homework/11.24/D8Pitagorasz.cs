
using UnityEngine;

public class D8Pitagorasz : MonoBehaviour
{
    [SerializeField] int a, b, c;
    [SerializeField] bool isPythagorean;

    void OnValidate()
    {
        isPythagorean = IsPythagorean(a, b, c);
    }

    // L�nyegi megold�s: 
    bool IsPythagorean(int a, int b, int c)
    {
        float hypotenuse = Mathf.Max(a, b, c);       // �tfog�
        float leg1 = Mathf.Min(a, b, c);              // Egyik befog�
        float leg2 = a + b + c - hypotenuse - leg1; // M�sik befog�

        // Pihagorasz t�tel alkalmaz�sa:
        return leg1 * leg1 + leg2 * leg2 == hypotenuse * hypotenuse;
    }
}
