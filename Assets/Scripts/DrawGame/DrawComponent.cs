using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawComponent : MonoBehaviour
{
    LineRenderer lineRenderer;

    public void PenDown(Ray ray) {
        GameObject drawingGameObject = new GameObject("drawing");
        lineRenderer = drawingGameObject.AddComponent<LineRenderer>();
        lineRenderer.positionCount = 0;
        lineRenderer.startWidth = 0.01f;
        lineRenderer.endWidth = 0.01f;
    }

    public void MovePenTo(Ray ray) {
        Vector3[] newPositions = new Vector3[lineRenderer.positionCount + 1];
        for (int i = 0; i < lineRenderer.positionCount; i++) {
            newPositions[i] = lineRenderer.GetPosition(i);
        }
        newPositions[newPositions.Length - 1 ] = RayToDrawPoint(ray);
        lineRenderer.positionCount = newPositions.Length;
        lineRenderer.SetPositions(newPositions);
    }

    public void PenUp()
    {
    }

    private Vector3 RayToDrawPoint(Ray ray) {
        return ray.origin + ray.direction.normalized * 0.1f;
    }
    
}
