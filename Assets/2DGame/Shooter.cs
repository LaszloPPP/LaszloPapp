using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum ShootingPattern
{
    First,
    Sequence,
    Random,
    PingPong
}

public class Shooter : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Transform startPoint;
    [SerializeField] GameObject[] projectiles;
    [SerializeField] KeyCode fireKey = KeyCode.X;
    [SerializeField] ShootingPattern pattern;

    int index = 0;

    private void Update()
    {

        if (Input.GetKeyDown(fireKey))
        {
            int i;
            if (pattern == ShootingPattern.First)
                i = 0;
            else if (pattern == ShootingPattern.Sequence)
                i = index % projectiles.Length;
            else if (pattern == ShootingPattern.Random)
                i = Random.Range(0, projectiles.Length);
            else
                i = 0;
            GameObject newProjectile = Instantiate(projectiles[i]); //instatiate = példányosítás. adott objetumból készít másolatot
            newProjectile.transform.position = startPoint.position;

            Vector2 velocity = speed * transform.right;

            Projectile p = newProjectile.GetComponent<Projectile>();

            p.SetVelocity(velocity);

            index++;
            /*if (index >= projectiles.Length)
            {
                index = 0;
            }
            */

        }


    }

}
