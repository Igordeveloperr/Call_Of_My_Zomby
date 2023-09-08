using UnityEngine;
using System;
using TMPro;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update
    private int time,enemi,wave,enemiMax;
    public int interval;
    public static int kils,points;
    public GameObject obj;
    public Transform[] SpawnPoint;
    public Transform[] Windows;
    public Transform player;
    private int i;
    public TMP_Text Text,Text2;
    private System.Random rand = new System.Random();
    void Start()
    {
        time = 0;
        points = 0;
        Text.text = "1";
        Text2.text = "0";
        wave = 1;
        enemiMax=5;
        enemi = 0;
        kils = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time += 1;
        Text2.text = points.ToString();
        if((time>interval) )
        {
            time = 0;
            if (enemi<enemiMax){
            i = rand.Next(12);
            GameObject NewObj = Instantiate(obj, SpawnPoint[i].position, Quaternion.Euler(0f,0f,0f));
            NewObj.GetComponent<Navigation>().goal = Windows[i];
            enemi += 1;
            }
        }
        if(kils>=enemiMax){
            enemi = 0;
            kils = 0;
            wave +=1;
            enemiMax = 5*wave;
            Text.text = wave.ToString();
        }
    } 
}
