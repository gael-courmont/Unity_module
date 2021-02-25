using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class RollingBall : MonoBehaviour
{
    private Rigidbody blancheRB;
    private GameObject canne;
    private void Awake()
    {
        

        

    }
    private void Start()
    {
        //canne=GameObject.Find("Canne");
        blancheRB = GetComponent<Rigidbody>();


    }
    private void Update()
    {
        
        if (Input.GetButtonUp("Jump") & blancheRB.velocity.magnitude==0)
        {
            foreach (GameObject go in Resources.FindObjectsOfTypeAll<GameObject>())
            { 
                if (go.name == "Canne")
                {
                    go.SetActive(true);
                }
            }
            
        }

    }
}