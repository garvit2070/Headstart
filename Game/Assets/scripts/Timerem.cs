using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timerem : MonoBehaviour
{
    public Text timer;
    float starttime;
    // Start is called before the first frame update
    void Start()
    {
       
        starttime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time - starttime ;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        timer.text = minutes + ":" + seconds;

        if(seconds==35.ToString() )
        {
            SceneManager.LoadScene(9);
        }
    }
}
