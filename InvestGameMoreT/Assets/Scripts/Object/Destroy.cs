using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy_me(this.gameObject);
    }

    void Destroy_me(GameObject obj)
    {
        Destroy(obj);
    }
}
