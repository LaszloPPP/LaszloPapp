
using UnityEngine;

class D7Kerekites : MonoBehaviour
{
    /*
    [SerializeField] float num;
    [SerializeField] int remain;
    [SerializeField] int intnum;

    private void OnValidate()
    {
        int remain = (int)num;

    }
    */

    float Floor(float num)
    {
        //return (int)num;
        float remain = num % 1;
        return num - remain;
    }

    float Ceil(float num)
    {
        float remain = num % 1;
        //return num + 1 - remain;
        if (remain == 0) 
        return num;
        float result = num + 1 - remain;
        return num + 1 - remain;
    }
    float Round(float num)
    {
        float remain = num % 1;
        if (remain >= 0.5f)
            /*return num + 1;
        return num;*/
            return Ceil(num);
        return Floor(num);
    }

}
 