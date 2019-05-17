using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Encontrado : DefaultTrackableEventHandler
{
    public Controller controlador;
    public int tarjeta;

    protected override void OnTrackingFound()
    {
        controlador.activar(tarjeta);
    }

    protected override void OnTrackingLost()
    {
        controlador.desactivar(tarjeta);
    }
}
