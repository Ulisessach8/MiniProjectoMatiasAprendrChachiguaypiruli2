using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class ControllerPlayer : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D rb;
    public float speed = 3;
    public float jump = 3;
    public bool inGround;
    public float move;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            rb.linearVelocity = new Vector2(speed * Time.deltaTime, rb.linearVelocityY);
            animator.SetBool("Walk", true);
            transform.localScale = new Vector3(3, 3, 3);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.linearVelocity = new Vector2(-speed * Time.deltaTime, rb.linearVelocityY);
            animator.SetBool("Walk", true);
            transform.localScale = new Vector3(-3, 3, 3);
        }
        if (Input.GetKeyDown(KeyCode.Space) && inGround == true)
        {
            animator.SetTrigger("Jump");
            rb.linearVelocity = new Vector2(rb.linearVelocityX, jump * Time.deltaTime);
            inGround = false;

        }
        if(rb.linearVelocity == Vector2.zero)
        {
            animator.SetBool("Walk", false);
        }
        


        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            inGround = true;
        }
        
    }
}
