using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class RollingBall : MonoBehaviour
{
    
    public Rigidbody rb;
    private GameObject canne;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        canne=GameObject.Find("Canne");
        

    }
    private void FixedUpdate()
    {
        if (( rb.velocity.x<1f) && Input.GetButtonDown("Jump"))
        {
            
            canne.SetActive(true);
            Debug.Log("is pressed canne active");
        }

    }
}

