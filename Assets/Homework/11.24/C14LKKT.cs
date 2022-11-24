
using UnityEngine;

public class C14LKKT : MonoBehaviour
{
    [SerializeField] int numA, numB, lkkt;

    private void OnValidate()
    {
        lkkt = Lnko(numA, numB);
    }
    /*void Lkkt(int a, int b)
    {
    int lkkt;
    }
    */

    int Lnko(int a, int b)
    {
        if (a > b)
        {
            int remain = 0;
            while (a / b > 0)
            {
                int mod = a % b;
                remain = mod;

            }
            return remain;
        }
        else if (b < a)
        {
            int remain = 0;
            while (b / a > 0)
            {
                int mod = a % b;
                remain = mod;

            }
            return remain;
        }
        else
        {
            return a;
        }
    }
}


