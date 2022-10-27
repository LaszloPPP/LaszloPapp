using UnityEngine;

class OnValidatePractice : MonoBehaviour
{
    // [] attrib�tumok
    [SerializeField] int intSetting; //settinget ad a komponenshez Unityben
    [SerializeField] float floatSetting;
    [SerializeField] string stringSetting;
    [SerializeField] bool boolSetting;
    [SerializeField] int startAmmo = 34;

    [Space]
    [SerializeField] float num1, num2;
    [SerializeField] float sum;

    int fieldVariable = 55; // Field / oszt�lyv�ltoz� / tagv�ltoz�

    void OnValidate() 
    {
        sum = num1 + num2;
    }

    void Start()
    {
        int localVariable = 66;
        int summa = localVariable + fieldVariable + intSetting;

        Debug.Log(summa);
    }
}

    
