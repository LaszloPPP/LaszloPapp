using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBox : MonoBehaviour

{
    [SerializeField] int damage = 10;
    [SerializeField] bool instaKill = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        HealthObject healthObject = collision.gameObject.GetComponent<HealthObject>();
        if (healthObject != null)
        {
            if (instaKill)
            {
                healthObject.Kill();
            }
            else
            {
                healthObject.Damage(damage);
            }
        }

        Debug.Log("You Died");
        //Destroy(collision.gameObject);
    }
}
