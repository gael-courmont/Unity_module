using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;
using UnityEngine.UIElements;

public class BougerCanne : MonoBehaviour
{
    public Rigidbody rb;
    private Transform Blanche;
    [SerializeField] private CapsuleCollider collider;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    private void OnCollisionEnter(Collision other)
    {
        this.enabled = false;
        rb.isKinematic = false;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        transform.position = Blanche.position + new Vector3(-7.1f, 0f, 0f);
    }

    private void Shoot()
    {
        Vector3 deltaPosition =
            new Vector3(transform.position.x, 0f, 0f) * Input.GetAxis("Horizontal");
        rb.AddForce(deltaPosition*1000f);
        
    }
    private void FixedUpdate()
    {

        Vector3 deltaPosition =
            new Vector3(transform.position.x, 0f, 0f) * Input.GetAxis("Horizontal");
        rb.AddForce(deltaPosition*100f);


        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
        
    }
}
