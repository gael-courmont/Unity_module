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
    [SerializeField] private Material highlightmat;
    private bool isDragging;
    private Vector3 MousePosition;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        isDragging = false;
    }

    private void OnCollisionEnter(Collision other)
    {
        rb.isKinematic = false;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        transform.position = Blanche.position + new Vector3(-7.1f, 0f, 0f);
        this.gameObject.SetActive(false);
    }

    private void replace()
    {
        transform.position = new Vector3(-7f, 0f, 0f);
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


        if (Input.GetMouseButton(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit,1000f,LayerMask.GetMask("canne")))
            {
                isDragging = true;
                Debug.Log(hit.transform.name);
                // Stocker position actuelle de la souris
                MousePosition = Input.mousePosition;


            }
        }

        if (isDragging)
        {
            Vector3 difference = Input.mousePosition - MousePosition;
            Debug.Log(difference);
            // check difference position actuelle initiale
            // par exemple vers la droite = queue se rapproche (ça suppose que la caméra regarde toujours avec le même angle la canne, sinon il faut faire du produit scalaire/vectoriel)
            
        }


    }
}
