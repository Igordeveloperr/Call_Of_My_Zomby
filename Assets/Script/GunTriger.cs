using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunTriger : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start() {
        GetComponent<SpriteRenderer>().color = Color.white;
    }
  private void OnTriggerEnter(Collider other) {
    if(other.gameObject.tag=="Player"){
        GetComponent<SpriteRenderer>().color = Color.yellow;
    }
  }
  private void OnTriggerExit(Collider other) {
    if(other.gameObject.tag=="Player"){
        GetComponent<SpriteRenderer>().color = Color.white;
    }
  }

    
   
}
