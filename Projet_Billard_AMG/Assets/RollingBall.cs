using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingBall : MonoBehaviour
{
    [SerializeField] private Transform cameraTransform;
    public Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        Vector3 cameraRight = cameraTransform.right;
        Vector3 cameraForward = cameraTransform.forward;

        Vector3 deltaPosition =
            new Vector3(cameraRight.x, 0f, cameraRight.z) * Input.GetAxis("Horizontal")
            + new Vector3(cameraForward.x, 0f, cameraForward.z) * Input.GetAxis("Vertical");
        rb.AddForce(deltaPosition*1000f);
    }
}
