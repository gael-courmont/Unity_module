using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class RollingBall : MonoBehaviour
{
    [SerializeField] private Transform cameraTransform;
    public Rigidbody rb;
    private GameObject canne;
<<<<<<< Updated upstream:Projet_Billard_AMG/Assets/RollingBall.cs
    private Vector3 min_vel=new Vector3(1f,1f,1f);
=======
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        canne=GameObject.Find("Canne");
    }
>>>>>>> Stashed changes:Projet_Billard_AMG/Assets/Scripts/RollingBall.cs
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        canne = this.transform.GetChild(0).gameObject;

    }
    private void FixedUpdate()
    {
        if (( rb.velocity.x<min_vel.x) && Input.GetButtonDown("Jump"))
        {
            
            canne.SetActive(true);
            Debug.Log("is pressed canne active");
        }

    }
}
