using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField] private Animator animacionEnemigo;
    private GameManager script;

    void Start()
    {
        GameObject gameManager = GameObject.Find("GameManager");
        if (gameManager != null)
        {
            script = gameManager.GetComponent<GameManager>();
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Arma"))
        {
            animacionEnemigo.SetTrigger("Morir");
            GetComponent<BoxCollider>().enabled = false;
            script.EnemigoEliminado();
        }
    }

    public void ActivarEnemigo()
    {
        animacionEnemigo.SetTrigger("Activar");
    }
}
