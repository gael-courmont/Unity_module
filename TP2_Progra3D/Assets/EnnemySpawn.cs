using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnnemySpawn : MonoBehaviour
{
    
    int starting_ennemies = 3; 
    int enemyname = 0;
    int max_ennemies = 10;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < starting_ennemies; i++){
            Spawn();
            ennemies+=1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        float a = UnityEngine.Random.Range(-4f,2f);
        float b = UnityEngine.Random.Range(2.2f,5f);
        float c = UnityEngine.Random.Range(10f,15f);
        GameObject Enemy = (GameObject) Instantiate(Resources.Load("Ennemy"), new Vector3(a,b,c), Quaternion.Euler(0, -90,0));
        Enemy.name = "Enemy" + enemyname;
        enemyname ++;
        
    }

}
