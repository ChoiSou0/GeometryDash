using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFly_Ctrl : MonoBehaviour
{
    public float Fly_Power;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        FLy();
        Turn();
    }

    private void FLy()
    {
        if (Input.GetKey(KeyCode.Mouse0))
            rb.AddForce(Vector2.up * Fly_Power, ForceMode2D.Impulse);
    }

    private void Turn()
    {
        transform.rotation = Quaternion.Euler(0, 0, rb.velocity.y * 4);
    }

}
