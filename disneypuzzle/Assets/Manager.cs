using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    int yerlestirilenparca =0;
    int toplam_puzzle=16;
    void Start()
    {
        
    }
    public void SayiArtt�r()
    {
        yerlestirilenparca++;
        if (yerlestirilenparca == toplam_puzzle)
        {
            Debug.Log("BA�ARILI");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
