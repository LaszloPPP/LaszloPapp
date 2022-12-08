using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flappy : MonoBehaviour
{
    [SerializeField] float jumpHeight = 1f;
    [SerializeField] KeyCode jumpButton = KeyCode.UpArrow;   
    [SerializeField] float gravity = -9.18f;

    Vector3 velocity;
    Vector3 originalPosition;

    private void Start()
    {
        
        Reset();
    }

    //private void FixedUpdate()

    private void Update()
          
    
    {
        bool jump = Input.GetKeyDown(jumpButton);
        float yPosition = transform.position.y;
        bool isDead = Mathf.Abs(yPosition) > 5;

        if (jump)
        {
            velocity.y = jumpHeight;
        }

        transform.position += velocity * Time.deltaTime;

        if (isDead)
        {
            Debug.Log("Game Over");
            Reset();
        }

        //gravity

        velocity.y += gravity * Time.deltaTime;

        


    }

    private void Reset()
    {
        originalPosition = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
    }
}
