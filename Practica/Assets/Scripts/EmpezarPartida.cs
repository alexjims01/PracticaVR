using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmpezarPartida : MonoBehaviour
{
    [SerializeField] private GameObject[] enemigos;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            foreach(GameObject enemigo in enemigos)
            {
                enemigo.GetComponent<Enemigo>().ActivarEnemigo();
            }
        }
    }
}
