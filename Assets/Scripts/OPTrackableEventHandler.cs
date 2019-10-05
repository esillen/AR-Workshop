using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OPTrackableEventHandler : DefaultTrackableEventHandler
{
    protected override void OnTrackingFound()
    {

        Debug.Log("Tracking found!");
        var rendererComponents = GetComponentsInChildren<Renderer>(true);

        // Disable rendering:
        foreach (var component in rendererComponents)
        {
            component.enabled = true;
        }
    }

    protected override void OnTrackingLost()
    {
        Debug.Log("Tracking lost :(");
        var rendererComponents = GetComponentsInChildren<Renderer>(true);

        // Disable rendering:
        foreach (var component in rendererComponents)
        {
            component.enabled = false;
        }
   }
}
