
using UnityEngine;

 class C9Hatvanyozas : MonoBehaviour
{
    [SerializeField] int baseNumber, exponent, result;
    private void OnValidate()
    {
        result = 1;

        for (int i = 0; i < exponent; i++)
            result *= baseNumber;
    }
}
