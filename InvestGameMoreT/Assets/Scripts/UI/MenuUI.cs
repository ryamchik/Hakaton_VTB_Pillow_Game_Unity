using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuUI : MonoBehaviour
{
    public class CollisionBottom : MonoBehaviour
    {
        void OnCollisionEnter2D(Collision2D collision)
        {
            Destroy(collision.gameObject);
            //���� �������
        }
    }
}
