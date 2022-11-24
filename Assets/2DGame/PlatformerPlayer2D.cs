
using UnityEngine;

public class PlatformerPlayer2D : MonoBehaviour
{
    [SerializeField] new Rigidbody2D rigidbody; //ha nincs New warningot kapunk
    [SerializeField] HealthObject healthObject;

    [SerializeField] float jumpForce;
    [SerializeField] float horizontalSpeed;
    [SerializeField] int airJump;

    bool isGrounded;
    //bool isOnJumpPlatform;
    JumpMultiplier jumpPlatform;
    int currentAirJumpBudget;

    void OnValidate()
    {
        //ezzel váltjuk ki jhogy Unity editorban kelljen behúzni a objectet amin használni akarjuk a scriptet
        rigidbody = GetComponent<Rigidbody2D>();
        healthObject = GetComponent<HealthObject>();
    }
    void Update()
    {

        if (healthObject != null && healthObject.IsDead())
            return;
        //jump
        if ((isGrounded || currentAirJumpBudget > 0) && Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.velocity = Vector2.zero;
            Vector2 jump = Vector2.up*jumpForce;

            if (jumpPlatform!=null)
                jump *= jumpPlatform.multiplier;

            rigidbody.AddForce(jump, ForceMode2D.Impulse); //AddForce-ál nem kell time.deltatime. ott van, csak a háttérben fut. ha pedig nem akarjuk akkor kell a forcemode2d. azon belül "force" folymatos, "impulse" egyszeri

            if (!isGrounded)
                currentAirJumpBudget--;
        }


        
    }

    private void FixedUpdate()
    {
        if (healthObject != null && healthObject.IsDead())
            return;

        //movement
        float inputX = Input.GetAxis("Horizontal");
        Vector2 velocity = new Vector2(inputX * horizontalSpeed, rigidbody.velocity.y);
        rigidbody.velocity = velocity;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
        currentAirJumpBudget = airJump;
        //Debug.Log("Collide:" + collision.otherCollider.name);
        JumpMultiplier platform = collision.gameObject.GetComponent<JumpMultiplier>();

        if (platform != null)
        {
            Debug.Log("Collided: Jump Multiplier");
            jumpPlatform = collision.gameObject.GetComponent<JumpMultiplier>();
            float mult=platform.multiplier;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
        //jumpPlatform = null;
        //Debug.Log("Exit");
    }
}
