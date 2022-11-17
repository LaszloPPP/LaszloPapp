
using UnityEngine;

public class PlatformerPlayer2D : MonoBehaviour
{
    [SerializeField] new Rigidbody2D rigidbody; //ha nincs New warningot kapunk
    [SerializeField] float jumpForce;
    [SerializeField] float horizontalSpeed;
    [SerializeField] int airJump;

    bool isGrounded;
    int currentAirJumpBudget;

    void OnValidate()
    {
        //ezzel váltjuk ki jhogy Unity editorban kelljen behúzni a objectet amin használni akarjuk a scriptet
        rigidbody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        //jump
        if ((isGrounded || currentAirJumpBudget>0) && Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.velocity = Vector2.zero;
            rigidbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse); //AddForce-ál nem kell time.deltatime. ott van, csak a háttérben fut. ha pedig nem akarjuk akkor kell a forcemode2d. azon belül "force" folymatos, "impulse" egyszeri
            if (!isGrounded)
                currentAirJumpBudget--;
        }

        //movement
        float inputX = Input.GetAxis("Horizontal");
        Vector2 velocity = new Vector2(inputX*horizontalSpeed, rigidbody.velocity.y);
        rigidbody.velocity = velocity;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
        currentAirJumpBudget = airJump;
        //Debug.Log("Collide:" + collision.otherCollider.name);
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
        //Debug.Log("Exit");
    }
}
