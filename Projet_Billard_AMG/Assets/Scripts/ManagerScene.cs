using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ManagerScene : MonoBehaviour
{
    public void HandleClick()
    {
        SceneManager.LoadScene("GameScene");
    }
}


