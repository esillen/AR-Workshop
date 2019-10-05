using UnityEngine;
using Vuforia;

public class DeployStageOnce : MonoBehaviour
{
    public PlaneFinderBehaviour planeFinderBehaviour;
    public bool IsContentPlaced {
        get {
            return isContentPlaced;
        }
    }
    private bool isContentPlaced = false;

    public void TryPlaceContent(Vector2 screenPosition)
    {
        if (!isContentPlaced)
        {
            planeFinderBehaviour.PerformHitTest(screenPosition);
        }
    }

    public void OnContentPlaced()
    {
        isContentPlaced = true;
    }

}
