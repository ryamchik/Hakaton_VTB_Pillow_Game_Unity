using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldScr : MonoBehaviour
{
    public int GoldCoin;

    void OnCollisionEnter2D(Collision2D collision)
    {
        GoldCoin++;
        //Debug.Log(GoldCoin);
    }

    void Update()
    {
        GoldCoin *= (int)Random.Range(0.99f, 1.02f);
    }
}
