
using UnityEngine;

public class E5LepesSzamlalas : MonoBehaviour
{
    [SerializeField] Vector2 a, b, step;
    [SerializeField] int stepCount;

    private void OnValidate()
    {
        Vector2 dirVec = b - a;
        float distance = dirVec.magnitude;
        stepCount = Mathf.CeilToInt(distance / 1f);
        step = dirVec / stepCount;
    }
}
