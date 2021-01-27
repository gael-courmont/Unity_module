using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private const float LifeSpan = 3f;
    private float timer = 0f;

    private void Update() {
        StartCoroutine (DestroyIn3Seconds());
    }

    private IEnumerator DestroyIn3Seconds (){
        yield return new WaitForSeconds(3f);
        Destroy (gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name=="Body")
        {
            Destroy (other.transform.parent.gameObject);       
        }
        else 
        {
            Destroy (other.gameObject);
        }
        Destroy (gameObject);
    }

}
