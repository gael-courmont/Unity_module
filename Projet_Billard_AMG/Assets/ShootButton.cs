using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootButton : MonoBehaviour
{

    [SerializeField] private GameObject canne;

    private bool is_pressed;
    // Start is called before the first frame update
    void Start()
    {
        is_pressed = false;
    }

    // Update is called once per frame
    void Update()
    {
        while (is_pressed)
        {
            
        }
    }

    void on_press()
    {
        is_pressed = true;
    }
}
