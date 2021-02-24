using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(
        fileName = "BallList",
        menuName = "List")]
public class BallList : ScriptableObject {
  [SerializeField] private List<GameObject> ballList;
  public List<GameObject> ballListget => ballList;   
}