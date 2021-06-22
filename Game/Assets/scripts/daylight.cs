using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class daylight : MonoBehaviour
{
    public Light s;
    // Start is called before the first frame update
    void Start()
    {
        s = GetComponent<Light>();
        
    }

    // Update is called once per frame
    void Update()
    {
       
        s.intensity-= 0.01f;
       
    }
}
