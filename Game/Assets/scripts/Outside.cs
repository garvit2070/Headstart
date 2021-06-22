using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Outside : MonoBehaviour
{
    public Rigidbody outs;
    // Start is called before the first frame update
    void Start()
    {
        outs = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.rigidbody.tag == "outside")
        {
            SceneManager.LoadScene(8);
        }
    }
}
