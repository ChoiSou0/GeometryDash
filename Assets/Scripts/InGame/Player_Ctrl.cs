using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Player_Ctrl : MonoBehaviour
{
    Rigidbody2D rb;
    public int JumpPower;
    public int Jump_Cnt = 1;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Go();
        Jump();
    }

    void Go()
    {
        Vector2 Pos = transform.position;

        Pos.x += 3 * Time.deltaTime;

        transform.position = Pos;
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && Jump_Cnt > 0)
        {
            rb.AddForce(Vector2.up * JumpPower, ForceMode2D.Impulse);
            transform.DORotate(new Vector3(0, 0, -90), 0.9f);
            transform.DORotate(new Vector3(0, 0, -175), 0.9f);
            Jump_Cnt--;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            Jump_Cnt = 1;
        }
    }


}
