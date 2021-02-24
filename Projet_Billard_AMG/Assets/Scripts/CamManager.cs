using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamManager : MonoBehaviour
{
    public Canvas canvas;
    public GameObject cam1;
    public GameObject cam2;
    public GameObject cam3;
    public GameObject cam4;
    public GameObject cam5;
    public GameObject cam6;
    public GameObject cam7;
    public GameObject cam8;

    private Camera camera1;
    private Camera camera2;
    private Camera camera3;
    private Camera camera4;
    private Camera camera5;
    private Camera camera6;
    private Camera camera7;
    private Camera camera8;
    
    // Start is called before the first frame update
    void Start()
    { 
        cam1.SetActive(true);
        cam2.SetActive(false);
        cam3.SetActive(false);
        cam4.SetActive(false);
        cam5.SetActive(false);
        cam6.SetActive(false);
        cam7.SetActive(false);
        cam8.SetActive(false);
        camera1=GetComponent<Camera>();
        camera2=GetComponent<Camera>();
        camera3=GetComponent<Camera>();
        camera4=GetComponent<Camera>();
        camera5=GetComponent<Camera>();
        camera6=GetComponent<Camera>();
        camera7=GetComponent<Camera>();
        camera8=GetComponent<Camera>();
        canvas.worldCamera = camera1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1)){
            cam1.SetActive(true);
            cam2.SetActive(false);
            cam3.SetActive(false);
            cam4.SetActive(false);
            cam5.SetActive(false);
            cam6.SetActive(false);
            cam7.SetActive(false);
            cam8.SetActive(false);
            canvas.worldCamera = camera1;
        }
        if (Input.GetKeyDown(KeyCode.Keypad2)){
            cam1.SetActive(false);
            cam2.SetActive(true);
            cam3.SetActive(false);
            cam4.SetActive(false);
            cam5.SetActive(false);
            cam6.SetActive(false);
            cam7.SetActive(false);
            cam8.SetActive(false);
            canvas.worldCamera = camera2;
        }
        if (Input.GetKeyDown(KeyCode.Keypad3)){
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(true);
            cam4.SetActive(false);
            cam5.SetActive(false);
            cam6.SetActive(false);
            cam7.SetActive(false);
            cam8.SetActive(false);
            canvas.worldCamera = camera3;
        }
        if (Input.GetKeyDown(KeyCode.Keypad4)){
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(false);
            cam4.SetActive(true);
            cam5.SetActive(false);
            cam6.SetActive(false);
            cam7.SetActive(false);
            cam8.SetActive(false);
            canvas.worldCamera = camera4;
        }
        if (Input.GetKeyDown(KeyCode.Keypad5)){
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(false);
            cam4.SetActive(false);
            cam5.SetActive(true);
            cam6.SetActive(false);
            cam7.SetActive(false);
            cam8.SetActive(false);
            canvas.worldCamera = camera5;
        }
        if (Input.GetKeyDown(KeyCode.Keypad6)){
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(false);
            cam4.SetActive(false);
            cam5.SetActive(false);
            cam6.SetActive(true);
            cam7.SetActive(false);
            cam8.SetActive(false);
            canvas.worldCamera = camera6;
        }
        if (Input.GetKeyDown(KeyCode.Keypad7)){
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(false);
            cam4.SetActive(false);
            cam5.SetActive(false);
            cam6.SetActive(false);
            cam7.SetActive(true);
            cam8.SetActive(false);
            canvas.worldCamera = camera7;
        }
        if (Input.GetKeyDown(KeyCode.Keypad8)){
            cam1.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(false);
            cam4.SetActive(false);
            cam5.SetActive(false);
            cam6.SetActive(false);
            cam7.SetActive(false);
            cam8.SetActive(true);
            canvas.worldCamera = camera8;
        }

    }
}
