using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class GameController : MonoBehaviour
{
    public DeployStageOnce deployStageOnce;

    private bool everStarted = false;


    // Ray contains data with origin and direction of the interaction
    public void StartInteraction(Ray ray) {
        if (deployStageOnce.IsContentPlaced)
        {
            OnInteractionStart(ray);
            everStarted = true;
        }
    }

    public void InteractOngoing(Ray ray)
    {
        if (deployStageOnce.IsContentPlaced && everStarted)
        {
            OnInteractionOngoing(ray);
        }
    }

    public void EndInteraction(Ray ray)
    {
        if (deployStageOnce.IsContentPlaced && everStarted)
        {
            OnInteractionEnd(ray);
        }
    }

    protected abstract void OnInteractionStart(Ray ray);
    protected abstract void OnInteractionOngoing(Ray ray);
    protected abstract void OnInteractionEnd(Ray ray);

}
