using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class descision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            SceneManager.LoadScene(5);
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            SceneManager.LoadScene(6);
        }
        if(Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene(3    );
        }
    }
}
