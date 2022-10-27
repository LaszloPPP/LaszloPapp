
using UnityEngine;

class MethodPractice : MonoBehaviour
{
    void Start()
    {
        Debug.Log("AAA");
        CountUntil("x", 12);
        Debug.Log("BBB");
        CountUntil("y", 34);
        Debug.Log("CCC");
        CountUntil("z", 11);
        Debug.Log("----------------------------");

        int z = Power(5, 3);
        int b = Power(4, 6);
        int c = Power(2, 10);

        Debug.Log($"{z} cool code {b} cool code {c}");
    }


    void CountUntil(string st, int count)
    {
        for (int i = 1; i <= count; i++)
        {
            Debug.Log(st + " " + i);

        }
    }

    //FÜGGVÉNYEK

    int Power(int baseNumber, int exponent)
    {
        int a=1;
        for (int i = 0; i < exponent; i++)
        {
            a *= baseNumber; //a = a * baseNumber
        }
        return a;
    }
}
