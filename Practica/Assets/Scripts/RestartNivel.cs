using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartNivel : MonoBehaviour
{
    [SerializeField] private GameObject[] enemigos;

    private GameManager script;

    void Start()
    {
        GameObject gameManager = GameObject.Find("GameManager");
        if (gameManager != null)
        {
            script = gameManager.GetComponent<GameManager>();
        }
        else
        {
            Debug.LogError("No se pudo encontrar el GameObject llamado GameManager");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            script.ReiniciarNivel();
        }
    }
}
