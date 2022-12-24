using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timescript : MonoBehaviour
{
    public float slowmo;
    public float realtime;
    private float rr = 0.02f;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
           
            // float rr = 0.02f;
            Time.timeScale = realtime;
            Time.fixedDeltaTime = rr * Time.timeScale;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            
            // float rr = 0.02f;
            Time.timeScale = realtime;
            Time.fixedDeltaTime = rr * Time.timeScale;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            
            // float rr = 0.02f;
            Time.timeScale = realtime;
            Time.fixedDeltaTime = rr * Time.timeScale;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
           
            // float rr = 0.02f;
            Time.timeScale = realtime;
            Time.fixedDeltaTime = rr * Time.timeScale;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {

            // float rr = 0.02f;
            Time.timeScale = slowmo;
            Time.fixedDeltaTime = rr * Time.timeScale;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {

            // float rr = 0.02f;
            Time.timeScale = slowmo;
            Time.fixedDeltaTime = rr * Time.timeScale;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {

            // float rr = 0.02f;
            Time.timeScale = slowmo;
            Time.fixedDeltaTime = rr * Time.timeScale;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {

            // float rr = 0.02f;
            Time.timeScale = slowmo;
            Time.fixedDeltaTime = rr * Time.timeScale;
        }
    }
    private void FixedUpdate()
    {
       

    }
}
