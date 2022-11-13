using UnityEngine;

class E2Iranyvektor : MonoBehaviour
{
    // Tesztel�sre:
    [SerializeField] Vector3 a, b;      // Bemeneti v�ltoz�k    
    [SerializeField] Vector3 result;    // Kimeneti v�ltoz�

    void OnValidate()
    {
        result = NormalFromAToB(a, b);
    }

    // L�nyegi megold�s: 
    Vector3 NormalFromAToB(Vector3 a, Vector3 b)
    {
        Vector3 v = b - a;    // Ez a-b�l b-be mutat� vektor
        return v.normalized;  // Ennek a normaliz�lt (1 hossz�) alakja kell.
    }
}