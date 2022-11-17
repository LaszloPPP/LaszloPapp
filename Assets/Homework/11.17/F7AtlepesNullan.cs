
using UnityEngine;

public class F7AtlepesNullan : MonoBehaviour
{
    float lastY;
    private void Start()
    {
        lastY = transform.position.y;
    }
    private void Update()
    {
        float currentY = transform.position.y;
        if (Mathf.Sign(currentY) != Mathf.Sign(lastY))
            Debug.Log("Zero height crosset at " + Time.time);
        lastY = currentY;
    }
}
