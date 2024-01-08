using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public float enemigos = 13f;
    public float enemigosIniciales = 13f;
    private bool partidaEmpezada = false;

    public TextMeshProUGUI textoCronometro;
    private float tiempoPasado = 0f;

    public TextMeshProUGUI texto;
    // Start is called before the first frame update
    void Start()
    {
        //texto = GetComponent<TextMeshProUGUI>();
        texto.text = "Enemigos " + enemigos.ToString() + "/" + enemigosIniciales.ToString();
    } 

    // Update is called once per frame
    void Update()
    {
        texto.text = "Enemigos " + enemigos.ToString() + "/" + enemigosIniciales.ToString();
        if(partidaEmpezada && enemigos > 0)
        {
            tiempoPasado += Time.deltaTime;
            string tiempoFormateado = FormatearTiempo(tiempoPasado);
            textoCronometro.text = tiempoFormateado;
        }
    }

    public void EnemigoEliminado()
    {
        enemigos = enemigos - 1;
        if(enemigos == 0)
        {
            textoCronometro.color = Color.blue;
        }
    }

    public void SpawnActivado()
    {
        if(partidaEmpezada == false)
        {
            partidaEmpezada = true;
        }
    }

    public void ReiniciarNivel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    string FormatearTiempo(float tiempo)
    {
        int minutos = Mathf.FloorToInt(tiempo / 60f);
        int segundos = Mathf.FloorToInt(tiempo % 60f);

        return string.Format("{0:00}:{1:00}", minutos, segundos);
    }
}
