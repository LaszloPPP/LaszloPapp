
using UnityEngine;

public class PlatformerCameraControl : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float maxVerticalDistance;

    void Update()
    {
        Vector3 playerPos = player.position;

        float y = transform.position.y;
        if (y < playerPos.y - maxVerticalDistance)
        { 
            y = playerPos.y-maxVerticalDistance; 
        }
        if (y > playerPos.y + maxVerticalDistance)
        {
            y = playerPos.y + maxVerticalDistance;
        }


        transform.position = new Vector3(playerPos.x, y, transform.position.z);
        //transform.position = new Vector3(playerPos.x,playerPos.y,transform.position.z); //teljesen követ az objectumot. függõleges+vízszintes
        //transform.position = new Vector3(playerPos.x, transform.position.y, transform.position.z); //csak vízszintesen követ
    }
}
