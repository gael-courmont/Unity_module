using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class BougerCanne : MonoBehaviour
{
    public Rigidbody rb;
    private Rigidbody BlancheRB;
    private GameObject blanche;
    
    [SerializeField] private BoxCollider collider;
    private bool isDraggingRotation;
    private Vector3 MousePosition;
    private bool have_shoot;
    private float puissance;
    private Vector3 position = default;
    private Camera Camera_Active;

    
    
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("canne collision with "+other.transform.name);
        rb.constraints = RigidbodyConstraints.FreezeAll;
        rb.isKinematic = true;
        gameObject.SetActive(false);
    }
    

    
    
    private void OnEnable()
    
    {
        blanche = (GameObject) GameObject.Find("WhiteBall");
        BlancheRB = blanche.GetComponent<Rigidbody>();
        rb = GetComponent<Rigidbody>();
        isDraggingRotation = false;
        puissance = 0;
        rb.velocity = Vector3.zero;
        rb.constraints = RigidbodyConstraints.FreezeRotation;
        have_shoot = false;
        rb.transform.rotation = quaternion.identity;
        rb.transform.rotation=Quaternion.AngleAxis(-90,Vector3.up);
        rb.transform.position = BlancheRB.transform.position + new Vector3(70f,0f,0f);
    }

    
    
    private void shoot()
    {
        
        rb.AddForce(rb.transform.forward * (puissance*30f));
    }
    private void Update()
    {  
        Camera_Active = Camera.allCameras[0];
        Shader.SetGlobalFloat("_Puissance",puissance);
        
        
        if(Input.GetButton("Fire1") & !have_shoot)
        {
            
            puissance +=0.5f;

        }

        if ((!Input.GetButton("Fire1") & puissance>0f) | puissance==90)
        {
            have_shoot = true;
            shoot();
        }
        if(Input.GetMouseButton(1))
        {
            rb.isKinematic = true;
            var ray = Camera_Active.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit,1000f,LayerMask.GetMask("canne")))
            {
                isDraggingRotation = true;
                
                // Stocker position actuelle de la souris
                MousePosition = Input.mousePosition;


            }
        }
        else
        {
            rb.isKinematic = false;
            isDraggingRotation = false;
        }
        

        if (isDraggingRotation)
        {
            
            Vector3 difference = Input.mousePosition - MousePosition;
            Debug.Log("rotating");
            position = new Vector3(BlancheRB.position.x+ 70f * Mathf.Cos(2 * Mathf.PI * difference.x*0.001f), BlancheRB.position.y, BlancheRB.position.z+ 70f *Mathf.Sin(2 * Mathf.PI*difference.x*0.001f));
            rb.transform.position = position;
            rb.transform.LookAt(BlancheRB.transform);
        }



    }
}