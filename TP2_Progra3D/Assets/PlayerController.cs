using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Transform selfTransform;
    [SerializeField] private Transform cameraTransform;
    [SerializeField] private Transform spheresHolderTransform;
    [SerializeField] private Transform spawnPointTransform;
    
    [SerializeField] private float speed = 0.1f;
    [SerializeField] private float cameraSensibility = 100f;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    private void Update()
    {
        MovePlayer();
        RotateCamera();
        Shoot();
    }

    private void MovePlayer()
    {
        Vector3 cameraRight = cameraTransform.right;
        Vector3 cameraForward = cameraTransform.forward;

        Vector3 deltaPosition =
            new Vector3(cameraRight.x, 0f, cameraRight.z) * Input.GetAxis("Horizontal")
            + new Vector3(cameraForward.x, 0f, cameraForward.z) * Input.GetAxis("Vertical");

        selfTransform.position += deltaPosition * speed;
    }

    private void RotateCamera()
    {
        cameraTransform.eulerAngles += new Vector3(
            -Input.GetAxis("Mouse Y"),
            Input.GetAxis("Mouse X"),
            0f) * cameraSensibility;
    }

    private void Shoot()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject sphere = (GameObject) Instantiate(Resources.Load("Bullet"),
                spawnPointTransform.position,
                Quaternion.identity,
                spheresHolderTransform);
            sphere.GetComponent<Rigidbody>().AddForce(cameraTransform.forward * 1000f);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger!");
    } 
}
