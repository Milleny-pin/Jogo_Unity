using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChuvaEspadas : MonoBehaviour
{
    public GameObject espadaPrefab;
    public float intervalo = 2f;
    public float velocidade = 8f;
    public float alturaSpawn = 6f;
    public float areaSpawn = 5f;

    void Start()
    {
        StartCoroutine(SpawnarEspadas());
    }

    IEnumerator SpawnarEspadas()
    {
        while (true)
        {
            yield return new WaitForSeconds(intervalo);

            float x = transform.position.x + Random.Range(-areaSpawn, areaSpawn);
            float y = transform.position.y + alturaSpawn;

            GameObject espada = Instantiate(espadaPrefab, new Vector3(x, y, 0), Quaternion.identity);
            Rigidbody2D rb = espada.GetComponent<Rigidbody2D>();

            if (rb != null)
                rb.linearVelocity = new Vector2(0, -velocidade);

            Destroy(espada, 5f);
        }
    }
}