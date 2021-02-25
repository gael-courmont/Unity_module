using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_stoping : MonoBehaviour
{
    [SerializeField] private Rigidbody BallRb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (BallRb.velocity.magnitude < 3.5f)
        {
            BallRb.velocity=Vector3.zero;
            BallRb.angularVelocity=Vector3.zero;
        }
    }
}
