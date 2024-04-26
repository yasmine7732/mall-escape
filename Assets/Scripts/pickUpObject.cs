using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpObject : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip effets;
    //public AudioClip door;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (gameObject.CompareTag("coin"))
            {
                AudioSource.PlayClipAtPoint(effets, transform.position);
                Inventory.instance.addCoins(10);
            }
            /*if (gameObject.CompareTag("shop"))
            {
                AudioSource.PlayClipAtPoint(door, transform.position);
            }*/
            Destroy(gameObject);
        }
    }
}
