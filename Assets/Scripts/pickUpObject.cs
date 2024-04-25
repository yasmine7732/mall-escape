using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpObject : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip sound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (gameObject.CompareTag("coin"))
            {
                AudioSource.PlayClipAtPoint(sound, transform.position);
                Inventory.instance.addCoins(10);
            }
            Destroy(gameObject);
        }
    }
}
