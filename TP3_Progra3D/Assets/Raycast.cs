using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    private Transform selfTransform;
    // Start is called before the first frame update

    void Awake ()
    {
        selfTransform = transform;

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit raycastHit;
         
        if (Physics.Raycast(
            transform.position, 
            transform.forward, 
            out raycastHit,
            Mathf.Infinity,
            LayerMask.NameToLayer("Cube"))){
        Debug.Log(raycastHit.distance);
        Debug.DrawRay(selfTransform.position, selfTransform.forward*raycastHit.distance, Color.green);
        }
        else{
            Debug.DrawRay(selfTransform.position, selfTransform.forward * 1000f , Color.red);
        }
    }
}
