using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arraies : MonoBehaviour
{



    private void OnValidate()
    {
        Rigidbody[] array1 = FindObjectsOfType<Rigidbody>();
        CapsuleCollider2D capsule = FindObjectOfType<CapsuleCollider2D>();

        SpriteRenderer renderer1 = GetComponent<SpriteRenderer>();
        SpriteRenderer renderer2 = GetComponentInChildren<SpriteRenderer>();
        SpriteRenderer renderer3 = GetComponentInParent<SpriteRenderer>();

        //többes szám verzó
        SpriteRenderer[] renderers1 = GetComponents<SpriteRenderer>();
        SpriteRenderer[] renderers2 = GetComponentsInChildren<SpriteRenderer>();
        SpriteRenderer[] renderers3 = GetComponentsInParent<SpriteRenderer>();
    }
}
