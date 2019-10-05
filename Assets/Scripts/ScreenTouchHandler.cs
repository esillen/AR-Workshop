using UnityEngine;

public class ScreenTouchHandler : MonoBehaviour
{
    public Camera camera;
    public GameController gameController;
    
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)) // mouse or touch action started this frame
        {
            gameController.StartInteraction(GetInputRay());
        }
        else if (Input.GetMouseButton(0) || (Input.touchCount > 0 && (Input.GetTouch(0).phase == TouchPhase.Moved || Input.GetTouch(0).phase == TouchPhase.Stationary))) // mouse or touch action ongoing
        {
            gameController.InteractOngoing(GetInputRay());
        } 
        else if (Input.GetMouseButtonUp(0) || (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)) // Mouse or touch action ended this frame
        {
            gameController.EndInteraction(GetInputRay());
        }
    }

    private Ray GetInputRay() {
        Vector3 interactionScreenPosition = Vector3.zero;
        if (Input.touchCount > 0)
        {
            interactionScreenPosition = Input.GetTouch(0).position;
        }
        else if (Input.GetMouseButtonDown(0))
        {
            interactionScreenPosition = Input.mousePosition;
        }

        Ray ray = camera.ScreenPointToRay(interactionScreenPosition);
        return ray;
    }

}
