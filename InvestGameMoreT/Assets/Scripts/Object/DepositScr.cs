using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepositScr : MonoBehaviour
{
    public int DepositCoin;

    System.DateTime start_time;

    private void Start()
    {
        start_time = System.DateTime.Now;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        DepositCoin++;
        //Debug.Log(DepositCoin);
    }

    // Update is called once per frame
    void Update()
    {
        if (System.DateTime.Now.Second - start_time.Second >= 59f)
        {
            Debug.Log("minute");
            DepositCoin *= (int)1.04f;
            start_time = System.DateTime.Now;
        }
    }
}
