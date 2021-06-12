using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    public BoxCollider2D collider;
    public GameObject player;

    public Animator animator;

    public float moveSpeed;
    public float jumpForce = 30f;
    public float speedMultipler = 1.5f;


    //public Animator animator;

    public bool isGrounded;
    public bool isRight = true;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGrounded = true;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
        StartCoroutine(Dotkniecie());
    }

    IEnumerator Dotkniecie()
    {
        collider.size = new Vector2(1, 1);
        yield return new WaitForSeconds(0.03f);
        collider.size = new Vector2(1, 2);
    }
    void Update()
    {
        //animator.SetFloat("Run", horizontalMove);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded)
            {
                rigidbody.velocity = (new Vector3(0, jumpForce));
                animator.Play("Jump");
            }

        }

    }

    private void FixedUpdate()
    {


        transform.position += new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed, 0f, 0f);

        if (isGrounded)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                if (isRight)
                {
                    if (Input.GetKey(KeyCode.Mouse0) || Input.GetKey(KeyCode.Mouse1))
                    {
                        animator.Play("JumpGun");
                    }
                    else
                    {
                        animator.Play("JumpRight");
                    }                    
                }
                else
                {
                    animator.Play("JumpLeft");
                }

            }
            else if (Input.GetKey(KeyCode.LeftShift))
            {
                transform.position += new Vector3(Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed * speedMultipler, 0f, 0f);
                if (Input.GetKey(KeyCode.D))
                {
                    if (Input.GetKey(KeyCode.Mouse0) || Input.GetKey(KeyCode.Mouse1))
                    {
                        animator.Play("RunGun");
                    }
                    else
                    {
                        animator.Play("RunRight");
                    }
                    isRight = true;
                }
                else
                {
                    animator.Play("RunLeft");
                    isRight = false;
                }
            }
            else if (Input.GetKey(KeyCode.D))
            {
                if(Input.GetKey(KeyCode.Mouse0) || Input.GetKey(KeyCode.Mouse1))
                {
                    animator.Play("WalkGun");
                }
                else
                {
                    animator.Play("WalkRight");
                }                
                isRight = true;
            }

            else if (Input.GetKey(KeyCode.A))
            {
                animator.Play("WalkLeft");
                isRight = false;
            }

            else if (Input.GetKey(KeyCode.Mouse0))
            {
                StartCoroutine(Shoot());
            }

            else if (Input.GetKey(KeyCode.Mouse1))
            {
                animator.Play("IdleGun");
            }

            else
            {
                if (isRight)
                {
                    animator.Play("Idle");
                }
                else
                {
                    animator.Play("IdleLeft");
                }

            }


        }

    }
    IEnumerator Shoot()
    {
        animator.Play("IdleGun");
        yield return new WaitForSeconds(0.5f);

    }
}
