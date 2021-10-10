using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StockScr : MonoBehaviour
{
    public int StockCoin;

    void OnCollisionEnter2D(Collision2D collision)
    {
        StockCoin++;
        //Debug.Log(StockCoin);
    }

    // Update is called once per frame
    void Update()
    {
        StockCoin *= (int)Random.Range(0.8f, 1.35f);
    }
}
