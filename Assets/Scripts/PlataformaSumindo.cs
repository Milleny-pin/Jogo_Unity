using System.Collections;
using UnityEngine;

public class PlataformaSumindo : MonoBehaviour
{
    public float delay = 2f;
    private bool ativado = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && !ativado)
        {
            ativado = true;
            StartCoroutine(Sumir());
        }
    }

    IEnumerator Sumir()
    {
        yield return new WaitForSeconds(delay);
        Destroy(gameObject);
    }
}
