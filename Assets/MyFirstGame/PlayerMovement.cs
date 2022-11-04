
using UnityEngine;
//commit test comment
public class PlayerMovement : MonoBehaviour
{
    /*[SerializeField] Vector3 velocity;*/
    [SerializeField] float speed;

    // Update is called once per frame
    void Update()
    {
        bool isRightPressed = Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D);//gomblenyomás lekérdezés. serlialized fieldben lehet átállítáni más gombnra, vagy itt helyben megadható más érték
        bool isLeftPressed = Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A);
        bool isUpPressed = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W);
        bool isDownPressed = Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S);

        //transform.position += velocity; //pozíció vektorához framenként hozzáadjuk a velocity vektor értékeit, így mozgást érünk el. sebességet befolyásolja az fps

        float x = 0;
        if (isRightPressed)
        {
            x += 1;
        }
        if (isLeftPressed)
        {
            x -= 1;
        }

        float z = isUpPressed ? 1 : (isDownPressed ? -1 : 0); //ugyanaz mint az x csak más megoldással

        Vector3 direction = new Vector3(x, 0, z); 
        direction.Normalize();
        Vector3 velocity = direction * speed;
        transform.position += velocity * Time.deltaTime; // transform.position = component.parameter // Time.deltaTime függetleníti a mozgást(vagy más változást) FPStõl
        if (direction != Vector3.zero)
        {
            transform.rotation = Quaternion.LookRotation(direction);
        }
        
    }
}
