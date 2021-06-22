using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Newmovement : MonoBehaviour
{
    public Rigidbody car;
    public float speed = 10;
   
    // Start is called before the first frame update
    void Start()
    {
        car = GetComponent<Rigidbody>();
       
    }

    // Update is called once per frame
    void Update()
    { if (Input.GetKey(KeyCode.LeftShift))
        {
           speed = 50;
        }
    else
        {
            speed = 10;
        }
      
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                car.AddForce(new Vector3(5, 0, 0) * speed);

            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                car.AddForce(new Vector3(-5, 0, 0) * speed);

            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                car.AddForce(new Vector3(0, 0, 5) * speed);

            }
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                car.AddForce(new Vector3(0, 0, -5) * speed);

            }
    }
}