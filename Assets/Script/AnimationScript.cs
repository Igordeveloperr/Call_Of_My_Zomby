using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      anim.SetFloat("Move",Mathf.Abs(GetComponent<Rigidbody>().velocity.magnitude));  
    }
}
