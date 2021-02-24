using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor;
using UnityEditorInternal.Profiling.Memory.Experimental;
using UnityEngine;
using UnityEngine.UIElements;

public class BougerCanne : MonoBehaviour
{
    public Rigidbody rb;
    private Transform Blanche;
    [SerializeField] private Rigidbody BlancheRB;
    [SerializeField] private BoxCollider collider;
    private bool isDraggingPosition;
    private bool isDraggingRotation;
    private Vector3 MousePosition;
    private Vector3 Initialposition;
    private bool have_shoot;
    private float puissance;
    //[SerializeField] Material 
    
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        isDraggingPosition = false;
        isDraggingRotation = false;
        Initialposition = this.transform.position;
        puissance = 0;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (have_shoot)
        {
            rb.constraints = RigidbodyConstraints.FreezeAll;
            BlancheRB.constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionY;
            rb.isKinematic = true;
            gameObject.SetActive(false);
        }

    }

    private void OnEnable()
    {
        puissance = 0;
        BlancheRB.constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
        rb.velocity = Vector3.zero;
        rb.constraints = RigidbodyConstraints.FreezeRotation;
        Debug.Log("enable can");
        have_shoot = false;
        rb.transform.rotation = quaternion.identity;
        rb.transform.rotation=Quaternion.AngleAxis(-90,Vector3.up);
        rb.transform.position = BlancheRB.transform.position + new Vector3(100f,0f,0f);
    }

    private void shoot()
    {
        Debug.Log("shoot");
        Debug.Log(puissance);
        rb.AddForce(rb.transform.forward * (puissance*100f));
    }
    private void FixedUpdate()
    {  
        Shader.SetGlobalFloat("_Puissance",puissance);
        
        
        if(Input.GetButton("Fire1"))
        {
            
            puissance += 1;
            have_shoot = true;
            if (puissance == 99)
            {
                shoot();
            }
        }

        if (Input.GetButtonUp("Fire1") & have_shoot)
        {
            shoot();
        }
        if(Input.GetMouseButton(1))
        {
            rb.isKinematic = true;
            have_shoot = true;
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit,1000f,LayerMask.GetMask("canne")))
            {
                isDraggingRotation = true;
                Debug.Log(hit.transform.name);
                // Stocker position actuelle de la souris
                MousePosition = Input.mousePosition;


            }
        }
        else
        {
            rb.isKinematic = false;
            isDraggingRotation = false;
        }

        if (isDraggingPosition)
        {
            Vector3 difference = Input.mousePosition - MousePosition;
            
            
               
                rb.MovePosition(new Vector3(rb.position.x + difference.x * 0.01f,rb.position.y,rb.position.z));
            
            
            

            
            // check difference position actuelle initiale
            // par exemple vers la droite = queue se rapproche (ça suppose que la caméra regarde toujours avec le même angle la canne, sinon il faut faire du produit scalaire/vectoriel)

        }

        if (isDraggingRotation)
        {
            
            Vector3 difference = Input.mousePosition - MousePosition;
            Debug.Log("rotating");
            //Quaternion moveRotation = Quaternion.RotateTowards(Quaternion.Euler(0, 0, Mathf.Floor(BlancheRB.rigidbody.transform.rotation.eulerAngles.z)), Quaternion.Euler(0, 0, endRotation), Time.deltaTime * RotateSpeed)
            BlancheRB.angularVelocity = BlancheRB.transform.up * difference.y;
        }
        else
        {
            BlancheRB.angularVelocity=Vector3.zero;
        }


    }
}
