using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Canhao : MonoBehaviour
{
    public GameObject bolinhaPrefebs;
    public float velocidade = 5f;
    public float intervalo = 4f;

    void Start()
    {
        StartCoroutine(Atirar());
    }

    IEnumerator Atirar()
    {
        while (true)
        {
            yield return new WaitForSeconds(intervalo);

            GameObject bolinha = Instantiate(bolinhaPrefebs, transform.position, Quaternion.identity);
            Rigidbody2D rb = bolinha.GetComponent<Rigidbody2D>();

            if (rb != null)
                rb.linearVelocity = new Vector2(-velocidade, 0);
        }
    }
}