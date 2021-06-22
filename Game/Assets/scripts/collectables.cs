using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class collectables : MonoBehaviour
{
    
     public GameObject Cube;
    public GameObject player;
    


    // Start is called before the first frame update
    void Start()
    {
        
        player = GetComponent<GameObject>();
        Cube = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(8);
        }
        
    }

    private void OnCollisionEnter(Collision other)
    {
        


            if (other.gameObject.tag == "collectable")
            {
                
                other.gameObject.SetActive(false);
                
            }
           
           
           
            


        
    }
 
}
