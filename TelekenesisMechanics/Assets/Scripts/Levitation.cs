using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levitation : MonoBehaviour
{
    public float levitationForce = 10.0f;
    public float gravityScale = 1.0f;
    public float drag = 0.1f;
    public float maxHeight = 10.0f;
    public KeyCode levitationKey = KeyCode.Space;
    private Rigidbody rb;
    private bool isLevitating = false;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
         // rb.gravityScale = gravityScale;
        rb.drag = drag;
    }
    void Update()
    {
        if (Input.GetKeyDown(levitationKey))
        {
            isLevitating = true;
            Debug.Log("ll");
        }
        else if (Input.GetKeyUp(levitationKey))
        {
            isLevitating = false;
        }
    }
    void FixedUpdate()
    {
        if (isLevitating)
        {
            if (transform.position.y < maxHeight)
            {
                rb.AddForce(Vector3.up * levitationForce, ForceMode.Acceleration);
            }
            else
            {
                rb.AddForce(Vector3.down * levitationForce, ForceMode.Acceleration);
            }
        }
    }
}
