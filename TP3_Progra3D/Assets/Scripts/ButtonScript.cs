using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonScript : MonoBehaviour
{
   [SerializeField] private Dialogue dialogue;
   [SerializeField] private TextMeshProUGUI textZone;
   private List<string> dialogSentences = new List<string>();
   private int globalCompt;

   public void Start(){
      dialogSentences = dialogue.dialogueget;
   }

   public void Handleclick(){
      if (globalCompt != dialogSentences.Count){
         textZone.text = dialogSentences[globalCompt];
         globalCompt ++;
      }
      
   }
}