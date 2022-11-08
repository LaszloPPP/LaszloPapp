
using UnityEngine;

class D7Kerekites : MonoBehaviour
{
    [SerializeField] float num;
    [SerializeField] int remain;
    [SerializeField] int intnum;

    private void OnValidate()
    {
        int remain = (int)num;

    }
}
 