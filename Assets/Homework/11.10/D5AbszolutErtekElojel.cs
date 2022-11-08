
using UnityEngine;

class D5AbszolutErtekElojel : MonoBehaviour
{
    [SerializeField] float number;
    [SerializeField] float abs;
    [SerializeField] float sign;
    void OnValidate()
    {
        if (number > 0)
        {
            abs = number;
            sign = 1;
        }

        else if (number<0)
        {
            abs = number + ((number*-1)*2);
            sign = -1;
        }
        else
        {
            abs = 0;
            sign = 0;
        }
    }
    /* megoldas
    void OnValidate()
    {
        absoluteVal = Abs(number);
        signVal = Sign(number);
    }

    // Lényegi megoldás:
    float Abs(float f)
    {
        if (number >= 0)
            return number;
        else 
            return -number;
    }  
    float Sign(float f)
    {
        if (number >= 0)
            return 1;
        else 
            return -1;
    }
    */
}
