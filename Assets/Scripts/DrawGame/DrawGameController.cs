using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawGameController : GameController
{

    public DrawComponent drawComponent;

    protected override void OnInteractionStart(Ray ray)
    {
        drawComponent.PenDown(ray);
    }

    protected override void OnInteractionOngoing(Ray ray)
    {
        drawComponent.MovePenTo(ray);
    }

    protected override void OnInteractionEnd(Ray ray)
    {
        drawComponent.MovePenTo(ray);
        drawComponent.PenUp();
    }

}
