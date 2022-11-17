using UnityEngine;

class E2Iranyvektor : MonoBehaviour
{
    // Tesztelésre:
    [SerializeField] Vector3 a, b;      // Bemeneti változók    
    [SerializeField] Vector3 result;    // Kimeneti változó

    void OnValidate()
    {
        result = NormalFromAToB(a, b);
    }

    // Lényegi megoldás: 
    Vector3 NormalFromAToB(Vector3 a, Vector3 b)
    {
        Vector3 v = b - a;    // Ez a-ból b-be mutató vektor
        return v.normalized;  // Ennek a normalizált (1 hosszú) alakja kell.
    }
}