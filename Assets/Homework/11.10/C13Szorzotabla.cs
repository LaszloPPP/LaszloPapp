
using UnityEngine;

class C13Szorzotabla : MonoBehaviour
{
    /*
    void Start()
    {
        int j=1;
        int k;

        for (int i = 1; i <= 10; i++)
        {
            
            j++;
            k = i * j;
            string result=$"{i}(i)*{j}(j)={k}";
            Debug.Log(result);
        }
    }
    */
    //MEGOLDAS
    void Start()
    {
        // K�t egym�sba �gyazott for ciklussal oldom meg a probl�m�t.
        for (int i = 1; i <= 10; i++)
        {
            for (int j = 1; j <= 10; j++)
                Debug.Log($"{i} * {j} = {i * j}");
        }
    }

}
