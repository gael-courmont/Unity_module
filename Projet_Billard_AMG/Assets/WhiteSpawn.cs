using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhiteSpawn : MonoBehaviour
{
    private float scale = 224f;
    private float baseX = 40.9f;
    private float baseY = 19.4f;
    private float baseZ = 17f;
    
    private float scaleCannex = 400f;
    private float scaleCanney = 224f;
    private float scaleCannez = 832f;
    // Start is called before the first frame update
    void Start()
    {
        SpawnBall();
    }

    public void SpawnBall()
    {
        GameObject ball = (GameObject) Instantiate( Resources.Load("BallWhite"), new Vector3(baseX,baseY,baseZ),Quaternion.identity);
        ball.transform.localScale = new Vector3(scale, scale, scale);
        ball.name = "WhiteBall";
        
        GameObject canne = (GameObject) Instantiate( Resources.Load("CueStick"));
        canne.transform.localScale = new Vector3(scaleCannex, scaleCanney, scaleCannez);
        canne.name = "Canne";
    }

}
