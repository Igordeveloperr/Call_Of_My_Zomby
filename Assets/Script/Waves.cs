using UnityEngine;
using System;
using TMPro;

public class Waves : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text Text;
    private int wave;
    void Start()
    {
        Text.text = "1";
        wave = 1;

    }

    // Update is called once per frame
    void Update()
    {
        wave +=1;
        Text.text = wave.ToString();
    }
}
