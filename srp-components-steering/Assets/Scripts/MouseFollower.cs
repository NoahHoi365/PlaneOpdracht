using UnityEngine;
using System.Collections;

public class MouseFollower : MonoBehaviour {

    public GameObject target;
    public delegate Vector2 planePos();
    
    void Update () {
        // Als je met de muis klikt: geef dan aan SteeringVehicle door
        // via SetTarget() waar het vliegtuig naartoe moet
        if (Input.GetMouseButtonDown(0))
        {
            target.transform.position = GetMousePosition();      
        }
        
    }

    Vector2 GetMousePosition()
    {
        var mousePosition = Input.mousePosition;
        mousePosition.z = 10;
        return Camera.main.ScreenToWorldPoint(mousePosition);
    }
}