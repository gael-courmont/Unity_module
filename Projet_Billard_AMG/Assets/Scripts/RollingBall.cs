using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class RollingBall : MonoBehaviour
{
    private Rigidbody blancheRB;
    private GameObject canne;

    private void Start()
    {
        blancheRB = GetComponent<Rigidbody>();


    }
    private void Update()
    {
        // faire réapparaitre canne
        if (Input.GetButtonUp("Jump") & blancheRB.velocity.magnitude<1)
        {
            // chercher canne
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