using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Transform startPoint;
    [SerializeField] GameObject[] projectiles;
    [SerializeField] KeyCode fireKey = KeyCode.X;

    int index=0;

    private void Update()
    {

        if (Input.GetKeyDown(fireKey))
        {

            GameObject newProjectile = Instantiate(projectiles[index]); //instatiate = példányosítás. adott objetumból készít másolatot
            newProjectile.transform.position = startPoint.position;

            Vector2 velocity = speed * transform.right;

            Projectile p = newProjectile.GetComponent<Projectile>();

            p.SetVelocity(velocity);

            index++;
            if (index >= projectiles.Length)
            {
                index = 0;
            }

        }


    }

}
