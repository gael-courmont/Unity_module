using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class BallsTrigger : MonoBehaviour
{
    
    private int Score;
    [SerializeField] private TextMeshProUGUI scoretext;
    public WhiteSpawn ScriptSpawnWhiteBall;
    void Awake()
    {
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoretext.text = "Balles empochées : "+Score;
    }
    
private void OnTriggerEnter(Collider other)
    {
        //Trigger fallen ball and its number
        Debug.Log("fallen ball : ");
        Debug.Log(other.gameObject.name);

        //Destroy fallen ball and add it in score UI
        Destroy(other.gameObject);
        
        //Respawn white ball
        if (other.gameObject.name == "WhiteBall")
        {
            ScriptSpawnWhiteBall.SpawnBall();
        }
        else
        {
            IncrementScore();
        }
        
    }

    public void IncrementScore()
    {
        Score += 1;
    }
}
