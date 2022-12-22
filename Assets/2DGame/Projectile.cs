using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float lifeTime=3f;

    Vector2 velocity;

    //float gameStartTime;

    void Start()
    {
        //gameStartTime = Time.time;
        StartCoroutine(DestroyCoroutine());
    }

    IEnumerator DestroyCoroutine()
    {
        yield return new WaitForSeconds(lifeTime);
        yield return null; //frame végéig vár
        Destroy(gameObject);
    }

    public void SetVelocity(Vector2 vel)
    {
        velocity = vel;  //vagy: this.velocity=velocity;
    }

    private void Update()
    {

        /*
        float projectileAge = Time.time-gameStartTime;
        transform.position += (Vector3)velocity * Time.deltaTime;
        if (projectileAge > lifeTime)
        {
            Destroy(gameObject);
        }
        */
    }
}
