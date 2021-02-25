using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class SolTrigger : MonoBehaviour
{
    

    public WhiteSpawn ScriptSpawnWhiteBall;





    private void OnTriggerEnter(Collider other)
    {



        Destroy(other.gameObject);

        //Respawn white ball
        if (other.gameObject.name == "WhiteBall")
        {
            ScriptSpawnWhiteBall.SpawnBall();

        }

    }
}