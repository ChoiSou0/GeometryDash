using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWave_Ctrl : MonoBehaviour
{
    public float Wave_Power;

    // Start is called before the first frame update
    void Start()
    {
        
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
            transform.rotation = Quaternion.EulerRotation(0, 0, 45);
            transform.Translate(Vector2.up * Wave_Power);
        }
        else
        {
            transform.Rotate(0, 0, -45);
            transform.Translate(Vector2.up * -Wave_Power);
        }
    }

}
