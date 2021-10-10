using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    float speed = 4;
    void MoveObject(Vector3 finPos)
    {
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, finPos, step);
    }

    private void Update()
    {
        GameObject[] coins = GameObject.FindGameObjectsWithTag("Coin");
        if (coins.Length > 0)
        {
            MoveObject(new Vector3(coins[0].transform.position.x, this.transform.position.y));
        }
    }
}
