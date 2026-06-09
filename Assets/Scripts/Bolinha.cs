using UnityEngine;
using UnityEngine.SceneManagement;

public class Bolinha : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.score = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

       
        Destroy(gameObject);
    }
}