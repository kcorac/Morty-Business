using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffinsManager : MonoBehaviour
{
    public GameManager CoffinsCount;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == gameObject.tag)
        {
            Destroy(gameObject);
            CoffinsCount.coffinsCount--;
        }
    }
}
