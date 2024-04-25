using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour
{
    public string nomScene;

    public AudioClip clip;
    public AudioSource audioSource;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) 
        {
            if (gameObject.CompareTag("shop")) {
                audioSource.clip = clip;
                audioSource.Play();
            }
            SceneManager.LoadScene(nomScene);
            
        }
    }

}
