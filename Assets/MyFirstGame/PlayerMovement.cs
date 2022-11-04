
using UnityEngine;
//commit test comment
public class PlayerMovement : MonoBehaviour
{
    /*[SerializeField] Vector3 velocity;*/
    [SerializeField] float speed;

    // Update is called once per frame
    void Update()
    {
        bool isRightPressed = Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D);//gomblenyom�s lek�rdez�s. serlialized fieldben lehet �t�ll�t�ni m�s gombnra, vagy itt helyben megadhat� m�s �rt�k
        bool isLeftPressed = Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A);
        bool isUpPressed = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W);
        bool isDownPressed = Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S);

        //transform.position += velocity; //poz�ci� vektor�hoz framenk�nt hozz�adjuk a velocity vektor �rt�keit, �gy mozg�st �r�nk el. sebess�get befoly�solja az fps

        float x = 0;
        if (isRightPressed)
        {
            x += 1;
        }
        if (isLeftPressed)
        {
            x -= 1;
        }

        float z = isUpPressed ? 1 : (isDownPressed ? -1 : 0); //ugyanaz mint az x csak m�s megold�ssal

        Vector3 direction = new Vector3(x, 0, z); 
        direction.Normalize();
        Vector3 velocity = direction * speed;
        transform.position += velocity * Time.deltaTime; // transform.position = component.parameter // Time.deltaTime f�ggetlen�ti a mozg�st(vagy m�s v�ltoz�st) FPSt�l
        if (direction != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(direction);
        }
        
    }
}
