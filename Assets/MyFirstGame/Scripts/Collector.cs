using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    int collectedValue = 0;

    private void OnTriggerEnter(Collider other)
    {
        Collectable collectable = other/*.gameObject*/.GetComponent<Collectable>();

        if (collectable != null)
        {
            collectedValue += collectable.GetValue();

            Debug.Log("Colllected: " + collectedValue);
            collectable.Teleport();
        }
    }
}
