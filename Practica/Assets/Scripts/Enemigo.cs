using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField] private Animator animacionEnemigo;

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Arma"))
        {
            animacionEnemigo.SetTrigger("Morir");
            GetComponent<BoxCollider>().enabled = false;
        }
    }

    public void ActivarEnemigo()
    {
        animacionEnemigo.SetTrigger("Activar");
    }
}
