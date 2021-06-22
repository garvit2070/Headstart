using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class collision : MonoBehaviour
{
    public Rigidbody b_room;
    // Start is called before the first frame update
    void Start()
    {
        b_room = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.rigidbody.tag == "bathroom")
        {
            SceneManager.LoadScene(7);

        }
    }

}
