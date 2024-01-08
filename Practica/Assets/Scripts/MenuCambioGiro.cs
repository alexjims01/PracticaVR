using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class MenuCambioGiro : MonoBehaviour
{
    [SerializeField] private ActionBasedSnapTurnProvider giroNoContinuo;
    [SerializeField] private ActionBasedContinuousTurnProvider giroContinuo;
    [SerializeField] private TeleportationProvider teletransportacion;
    [SerializeField] private ActionBasedContinuousMoveProvider movimientoContinuo;

    public void Seleccion(int index)
    {
        if(index == 0)
        {
            giroNoContinuo.enabled = true;
            giroContinuo.enabled = false;
        }
        if(index == 1)
        {
            giroNoContinuo.enabled = false;
            giroContinuo.enabled = true;
        }
        if(index == 2)
        {
            movimientoContinuo.enabled = true;
            teletransportacion.enabled = false;
        }
        if(index == 3)
        {
            movimientoContinuo.enabled = false;
            teletransportacion.enabled = true;
        }
    }

    public void Exit()
    {
        Application.Quit();
    }
}
