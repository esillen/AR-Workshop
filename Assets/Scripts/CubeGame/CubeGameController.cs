using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGameController : GameController
{

    public GameObject ballPrefab;
    public float throwSpeed = 5;

    protected override void OnInteractionEnd(Ray ray)
    {
        GameObject ball = Instantiate(ballPrefab, ray.origin, Quaternion.LookRotation(ray.direction));
        ball.GetComponent<Rigidbody>().velocity = throwSpeed * ball.transform.forward;
    }

    protected override void OnInteractionOngoing(Ray ray)
    {
        // Do nothing
    }

    protected override void OnInteractionStart(Ray ray)
    {
        // Do nothing
    }

}
