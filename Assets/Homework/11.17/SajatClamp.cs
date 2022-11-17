
using UnityEngine;

public class SajatClamp : MonoBehaviour
{
    

    float Clamp(float number, float min, float max)
    {
        if (number > max)
        {
            return max;
        }
        else if (number < min)
        {
            return min;
        }
        else
        { 
            return number; 
        }
    }

    float Clamp01(float number)
    {
        return Clamp(number, 0, 1);
    }
}
