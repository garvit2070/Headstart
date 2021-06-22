using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour
{
    public Rigidbody l;
    public Rigidbody c;
    // Start is called before the first frame update
    void Start()
    {
        c = GetComponent<Rigidbody>();
        l = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.rigidbody.tag == "last")
        {
            SceneManager.LoadScene(10);
        }
        
    }
    
    
}
