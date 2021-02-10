using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Compteur : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI counterTextComponent;
    private int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        counterTextComponent.text = "Nombre de pressions sur Espace : 0";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            counter++;
            counterTextComponent.text = "Nombre de pressions sur Espace : " + counter;
        }
    }
}