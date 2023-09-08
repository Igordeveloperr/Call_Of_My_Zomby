using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float timeDestroy = 5f;
    public float speed = 5f;
    public Rigidbody rb;

    
    void Start()
    {
    rb = GetComponent<Rigidbody>();

        Vector3 diference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotateZ = Mathf.Atan2(diference.x, diference.z) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(90f, 0f, -rotateZ+0f);
        
        rb.velocity = transform.up * speed;
        Invoke("DestroyBullet", timeDestroy);
    }

    void DestroyBullet()
    {
        Destroy(this.gameObject);
    }


}
