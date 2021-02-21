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
    [SerializeField] private BoxCollider collider;
    private bool isDragging;
    private Vector3 MousePosition;
    private Vector3 Initialposition;
    private bool have_shoot;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        isDragging = false;
        Initialposition = this.transform.position;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (have_shoot)
        {
            gameObject.SetActive(false);
        }

    }

    private void OnEnable()
    {
        have_shoot = false;
        this.transform.position = this.transform.position + new Vector3(5f,0f,0f);
    }

    private void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            have_shoot = true;
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
        else
        {
            isDragging = false;
        }

        if (isDragging)
        {
            Vector3 difference = Input.mousePosition - MousePosition;
            if (difference.x > 0)
            {
               
                rb.MovePosition(rb.position + difference * 0.01f);

            }

            if (difference.x < 0)
            {
                rb.MovePosition((rb.position + difference*0.01f));
            }

            
            // check difference position actuelle initiale
            // par exemple vers la droite = queue se rapproche (ça suppose que la caméra regarde toujours avec le même angle la canne, sinon il faut faire du produit scalaire/vectoriel)

        }


    }
}
