using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddingCoin : MonoBehaviour
{
    public GameHelper helper;
    int prise;

    [SerializeField]

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
           Add(ref helper.final_count_coins);
        }
    }

    public void Add(ref int count)
    {
        count += 1;
    }

    public void Add(ref float count)
    {
        count += 1;
    }
}
