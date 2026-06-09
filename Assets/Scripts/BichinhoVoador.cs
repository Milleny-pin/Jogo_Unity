using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BichinhoVoador : MonoBehaviour
{
    public float velocidade = 3f;
    public float distanciaHorizontal = 3f;
    public float distanciaVertical = 2f;
    public float tempoEspera = 0.5f;

    private Vector3 posicaoInicial;

    void Start()
    {
        posicaoInicial = transform.position;
        StartCoroutine(Voar());
    }

    IEnumerator Voar()
    {
        while (true)
        {
            // Direita
            yield return Mover(posicaoInicial + Vector3.right * distanciaHorizontal);
            yield return new WaitForSeconds(tempoEspera);

            // Esquerda
            yield return Mover(posicaoInicial + Vector3.left * distanciaHorizontal);
            yield return new WaitForSeconds(tempoEspera);

            // Centro
            yield return Mover(posicaoInicial);
            yield return new WaitForSeconds(tempoEspera);

            // Cima
            yield return Mover(posicaoInicial + Vector3.up * distanciaVertical);
            yield return new WaitForSeconds(tempoEspera);

            // Baixo
            yield return Mover(posicaoInicial + Vector3.down * distanciaVertical);
            yield return new WaitForSeconds(tempoEspera);

            // Centro
            yield return Mover(posicaoInicial);
            yield return new WaitForSeconds(tempoEspera);
        }
    }

    IEnumerator Mover(Vector3 destino)
    {
        while (Vector3.Distance(transform.position, destino) > 0.05f)
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                destino,
                velocidade * Time.deltaTime);
            yield return null;
        }
        transform.position = destino;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameManager.score = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}