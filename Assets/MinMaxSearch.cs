
using UnityEngine;

class MinMaxSearch : MonoBehaviour
{
    [SerializeField] int a, b;
    [SerializeField] int min, max;
    void OnValidate()
    {
        /*if (a > b)
        {
            min = b;
            max = a;
        }
        else
        {
            min = a;
            max = b;
        }*/
        if (a < b)
        {
            min = a;

        }
        else
        {
            min = b;

        }
        max = a > b ? a : b; //? és : operátorokra rákeresni!
        //------------------------Unity gyári változat függvény
        min = Mathf.Min(a, b);
        max = Mathf.Max(a, b);

        min = Minimum(a, b);
        max = Maximum(a, b);
    }

    int Minimum(int n1, int n2)
    {
        int result = n1 > n2 ? n2 : n1;

        return result;
    }

    int Maximum(int n1, int n2)
    {
        if (n1 > n2)
        {
            return n1;
        }
        else
        {
            return n2;
        }
    }
}
