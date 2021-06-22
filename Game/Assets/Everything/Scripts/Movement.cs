using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{


    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            rb.AddForce(new Vector3(0, 2, 0), ForceMode.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            rb.AddForce(new Vector3(0, -2, 0), ForceMode.Impulse);

        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.AddForce(new Vector3(0, 0, 2), ForceMode.Impulse);

        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.AddForce(new Vector3(0, 0, -2), ForceMode.Impulse);

        }
    }
}
