using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField] private BallList listBall;
   
    
    private float rayonBoule = 2.264f;
    private float ecartenX = 3.921f;
    private float baseX = -57.584f;
    private float baseY = 22f;
    private float baseZ = 7.998f;
    private int i = 0;
    // Start is called before the first frame update

    void Start()
    {
        for (int j = 0; j < 5; j++){
            float a = baseX;
            float b = baseY;
            float c = baseZ + j * 2 * rayonBoule;
            GameObject ball = (GameObject) Instantiate( listBall.ballListget[i], new Vector3(a,b,c),Quaternion.identity);
            ball.name = "Ball" + i;
            i++;
        }
        for (int j = 0; j < 4; j++){
            float a = baseX + ecartenX;
            float b = baseY;
            float c = baseZ + j * 2 * rayonBoule + rayonBoule;
            GameObject ball = (GameObject) Instantiate( listBall.ballListget[i], new Vector3(a,b,c),Quaternion.identity);
            ball.name = "Ball" + i;
            i++;
        }
        for (int j = 0; j < 3; j++){
            float a = baseX + ecartenX * 2;
            float b = baseY;
            float c = baseZ + j * 2 * rayonBoule;
            GameObject ball = (GameObject) Instantiate(listBall.ballListget[i], new Vector3(a,b,c),Quaternion.identity);
            ball.name = "Ball" + i;
            i++;
        }
        for (int j = 0; j < 2; j++){
            float a = baseX + ecartenX * 3;
            float b = baseY;
            float c = baseZ + j * 2 * rayonBoule;
            GameObject ball = (GameObject) Instantiate(listBall.ballListget[i], new Vector3(a,b,c),Quaternion.identity);
            ball.name = "Ball" + i;
            i++;
        }
        for (int j = 0; j < 1; j++){
            float a = baseX + ecartenX * 3;
            float b = baseY;
            float c = baseZ + j * 2 * rayonBoule;
            GameObject ball = (GameObject) Instantiate(listBall.ballListget[i], new Vector3(a,b,c),Quaternion.identity);
            ball.name = "Ball" + i;
            i++;
        }
    }
}
