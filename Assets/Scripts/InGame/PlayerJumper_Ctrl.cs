using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumper_Ctrl : MonoBehaviour
{
    public float Jumper_Power;
    public float Jumper_cnt;
    public bool isJump;
    Rigidbody2D rb;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Jump();
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && Jumper_cnt < 1 && isJump)
            rb.AddForce(Vector2.up * 3, ForceMode2D.Impulse);

        if (Input.GetKey(KeyCode.Mouse0) && Jumper_cnt < 1 && isJump)
        {
            rb.AddForce(Vector2.up * Jumper_Power, ForceMode2D.Impulse);
            Jumper_cnt += 2 * Time.deltaTime;
            Debug.Log("클릭중");
        }

        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            isJump = false;
            Debug.Log("클릭안함");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            Jumper_cnt = 0;
            isJump = true;
        }
    }

}
