using UnityEngine;

  [CreateAssetMenu(
        fileName = "NewDialogue",
        menuName = "Dialogue")]
public class Dialogue : ScriptableObject {
  

    [SerializeField] private string question;
    [SerializeField] private string answer;

    public string Question => question;
    public string Answer => answer;
}