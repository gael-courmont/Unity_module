using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnnemySpawn : MonoBehaviour
{
    
    int ennemies = 3;
    int enemyname = 0;
    public List<GameObject> enemyList = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        while (enemyList.Count < ennemies){
            float a = UnityEngine.Random.Range(-4f,2f);
            float b = UnityEngine.Random.Range(2.5f,5f);
            float c = UnityEngine.Random.Range(10f,15f);
            GameObject Enemy = (GameObject) Instantiate(Resources.Load("Ennemy"), new Vector3(a,b,c), Quaternion.Euler(0, -90,0));
            Enemy.name = "Enemy" + enemyname;
            enemyname ++;
            enemyList.Add(Enemy);
        }   
        
        for (int i = 0; i < enemyList.Count; i++)
        {   
            if (enemyList[i] == null){
                float a = UnityEngine.Random.Range(-4f,2f);
                float b = UnityEngine.Random.Range(2.5f,5f);
                float c = UnityEngine.Random.Range(10f,15f);
                enemyList[i] = (GameObject) Instantiate(Resources.Load("Ennemy"), new Vector3(a,b,c), Quaternion.Euler(0, -90,0));
            }   
        }
    }
}
