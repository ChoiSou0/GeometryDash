using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSqueak_Ctrl : MonoBehaviour
{
    public bool isFloor;
    Rigidbody2D rb;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GameObject.Find("Player_Squeak").GetComponent<Rigidbody2D>();
        animator = GameObject.Find("Player_Squeak").GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Turn();
    }

    public void Turn()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && isFloor)
        {
            rb.gravityScale *= -1;
        }

        if (rb.gravityScale == 1)
            animator.SetBool("isRollin", false);
        else
            animator.SetBool("isRollin", true);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Floor"))
            isFloor = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Floor"))
            isFloor = false;
    }
}
