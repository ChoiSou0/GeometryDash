using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUFO_Ctrl : MonoBehaviour
{
    public int Jump_Power;
    public int Turn_Power = 1;
    public bool isTurn; 
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(transform.rotation.eulerAngles);
        Jump();
        Turn();
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            rb.AddForce(Vector2.up * Jump_Power, ForceMode2D.Impulse);
            isTurn = true;
        }
    }

    private void Turn()
    {
        

        if (isTurn)
        {
            transform.Rotate(0, 0, transform.rotation.eulerAngles.z - Turn_Power);
        }
        else
        {
            //while (transform.rotation.z)
        }

    }

}
