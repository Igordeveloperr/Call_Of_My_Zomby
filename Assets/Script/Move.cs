using UnityEngine;
using UnityEngine.SceneManagement;
using System;
public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Camera1,bullet;
    //public Transform gun;
    public float Speed;
    private int time,Fire=1;
    private float Horizontal,Vertical;
    private Vector3 m_Velocity = Vector3.zero;
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Enemy")
        {
            SceneManager.LoadScene("Menu");
        }
    }

    void FixedUpdate() {

        Vector3 diference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - GetComponent<Transform>().position;
        float rotateZ = Mathf.Atan2(diference.x, diference.z) * Mathf.Rad2Deg;
        GetComponent<Transform>().rotation = Quaternion.Euler(90f, 0f, -rotateZ);
        time +=1;

        // if ( GetComponent<Rigidbody>().velocity.x + > Speed){  
        //     GetComponent<Rigidbody>().velocity = new Vector3(Speed, GetComponent<Rigidbody>().velocity.y, GetComponent<Rigidbody>().velocity.z);}

        // if ( GetComponent<Rigidbody>().velocity.x < -Speed){  
        //     GetComponent<Rigidbody>().velocity = new Vector3(-Speed, GetComponent<Rigidbody>().velocity.y, GetComponent<Rigidbody>().velocity.z);}

        // if ( GetComponent<Rigidbody>().velocity.z > Speed){  
        //     GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x, GetComponent<Rigidbody>().velocity.y, Speed);}

        // if ( GetComponent<Rigidbody>().velocity.z < -Speed){  
        //     GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x, GetComponent<Rigidbody>().velocity.y, -Speed);}
        Horizontal = Input.GetAxis("Horizontal");
        Vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(Horizontal, 0.0f, Vertical);
        // if(( Math.Abs(GetComponent<Rigidbody>().velocity.x) + Math.Abs(GetComponent<Rigidbody>().velocity.z)) <Speed){
             
        // }
        // GetComponent<Rigidbody>().Speed = movement * Speed * Time.fixedDeltaTime;
        
        GetComponent<Rigidbody>().velocity = Vector3.SmoothDamp(GetComponent<Rigidbody>().velocity, movement*Speed ,ref m_Velocity ,0.05f );
        if (GetComponent<Rigidbody>().velocity.y < 0 ) GetComponent<Rigidbody>().AddForce(0f,-100f,0f);
        
    

        if (Input.GetKey(KeyCode.Mouse0)&&(Fire==1))
        {
           GameObject NewBullet = Instantiate(bullet, transform.position + new Vector3(0f,-0.4f,0f), Quaternion.Euler(0f,0f,0f));
                    Physics.IgnoreCollision(GetComponent<Collider>(),NewBullet.GetComponent<Collider>(),true);
            Fire = 0;
            time = 0;
                    }
        if (time>30){
            time = 0;
            Fire = 1;
        }
    }
    private void Update() {
        Camera1.GetComponent<Transform>().position = new Vector3(GetComponent<Transform>().position.x,GetComponent<Transform>().position.y+2f,GetComponent<Transform>().position.z);
        
    }
    
    }
