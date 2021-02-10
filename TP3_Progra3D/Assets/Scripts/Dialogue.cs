using UnityEngine;
using TMPro;
using System.Collections.Generic;

[CreateAssetMenu(
        fileName = "NewDialogue",
        menuName = "Dialogue")]
public class Dialogue : ScriptableObject {
  [SerializeField] private List<string> dialogueML;
  public List<string> dialogueget => dialogueML;   
}
