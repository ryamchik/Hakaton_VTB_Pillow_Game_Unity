using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BondsScr : MonoBehaviour
{
    public int BondCoin;

    System.DateTime start_time;

    void OnCollisionEnter2D(Collision2D collision)
    {
        BondCoin++;
        //Debug.Log(BondCoin);
    }

    private void Start()
    {
        start_time = System.DateTime.Now;
    }

    // Update is called once per frame
    void Update()
    {
        if (System.DateTime.Now.Second - start_time.Second >= 30f)
        {
            Debug.Log("30 sec");
            BondCoin *= (int)Random.Range(1.05f, 1.15f);
            start_time = System.DateTime.Now;
        }
    }
}
