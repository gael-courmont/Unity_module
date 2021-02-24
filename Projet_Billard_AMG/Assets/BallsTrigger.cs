using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //Trigger fallen ball and its number
        Debug.Log("fallen ball : ");
        Debug.Log(other.gameObject.name);
        
        //Increment score in UI ***TO DO***
        //GameObject ScoreCount = GameObject.Find("Text") as GameObject;
        //ScoreCount.SendMessageUpwards("IncrementScore");
        
        //Destroy fallen ball and add it in score UI ***TO DO***
        Destroy(other.gameObject);
        
        //Respawn white and dark balls ***TO DO***
    }
}
