using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ignor : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag == "Bullet"){
             Physics.IgnoreCollision(GetComponent<Collider>(), other.gameObject.GetComponent<Collider>());   
        }
    }
}
