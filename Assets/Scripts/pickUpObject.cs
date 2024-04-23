using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpObject : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (gameObject.CompareTag("coin"))
            {
                Inventory.instance.addCoins(10);
            }
            Destroy(gameObject);
        }
    }
}
