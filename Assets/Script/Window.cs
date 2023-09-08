using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Window : MonoBehaviour
{
    public Sprite[] sprites;
    public SpriteRenderer win;
    public int step;
    public int time;
    public Transform player;
    void Start()
    {       
        step = 4;
        time = 0;
        win.sprite = sprites[step];
    }
    private void OnTriggerStay(Collider other) {

      if(other.gameObject.tag == "Enemy" && step<1){other.gameObject.GetComponent<Navigation>().goal = player; }

      if (other.gameObject.tag == "Enemy" && step>0){
                time += 1;
                if(time>250){
                    time = 0;
                    step-=1; 
                    win.sprite = sprites[step];
                }
                
            } 
       if (other.gameObject.tag == "Player" && step <4){
            time -=1;
            if(time<0){
                time = 500;
                step+=1; 
                win.sprite = sprites[step];
            }
        
       }  
    }
    
}
