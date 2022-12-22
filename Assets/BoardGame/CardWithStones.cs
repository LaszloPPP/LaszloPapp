using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardWithStones : MonoBehaviour
{
    
    List<Stone> stones = new List<Stone>();
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Stone s = collision.gameObject.GetComponent<Stone>();
        if (s != null)
        {
            stones.Add(s);
            Debug.Log(stones.Count);
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Stone s = collision.gameObject.GetComponent<Stone>();
        if (s != null)
        {
            stones.Remove(s);
            Debug.Log(stones.Count);

        }
    }
    
}
