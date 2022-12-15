using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float lifeTime=3f;

    Vector2 velocity;

    float gameStartTime;

    private void Start()
    {
        gameStartTime = Time.time;
    }

    public void SetVelocity(Vector2 vel)
    {
        velocity = vel;  //vagy: this.velocity=velocity;
    }

    private void Update()
    {

        float projectileAge = Time.time-gameStartTime;
        transform.position += (Vector3)velocity * Time.deltaTime;
        if (projectileAge > lifeTime)
        {
            Destroy(gameObject);
        }
    }
}
