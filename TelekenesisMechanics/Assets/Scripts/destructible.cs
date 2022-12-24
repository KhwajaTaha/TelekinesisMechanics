using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destructible : MonoBehaviour

{
    public GameObject Destroyed;
    private void OnCollisionEnter(Collision collision)
    {
        
        if(collision.gameObject.CompareTag("Box"))
        {
            Instantiate(Destroyed, transform.position, transform.rotation);
            Destroy(gameObject);
        }

        
    }
}
