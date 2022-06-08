using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWave_Ctrl : MonoBehaviour
{
    public float Wave_Power;
    public bool isFloor;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Waving();
    }

    private void Waving()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            isFloor = false;
            transform.rotation = Quaternion.Euler(0, 0, 45);
            transform.position += new Vector3(0, transform.rotation.z / Mathf.Abs(transform.rotation.z) * Wave_Power * Time.deltaTime, 0);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, -45);
            if (!isFloor)
                transform.position += new Vector3(0, transform.rotation.z / Mathf.Abs(transform.rotation.z) * Wave_Power * Time.deltaTime, 0);
        }

        if (isFloor)
            transform.rotation = Quaternion.Euler(0, 0, 0);


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
            isFloor = true;
    }

}
