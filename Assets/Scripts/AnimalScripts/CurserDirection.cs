using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurserDirection : MonoBehaviour
{

    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 10))
        {
            transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));
        }
    }
    // Start is called before the first frame update
    /* public Camera cam;

     void Update()
       {
           // Converting the mouse position to a point in 3D-space
           Vector3 point = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1));
           // Using some math to calculate the point of intersection between the line going through the camera and the mouse position with the XZ-Plane
           float t = cam.transform.position.y / (cam.transform.position.y - point.y);
           Vector3 finalPoint = new Vector3(t * (point.x - cam.transform.position.x) + cam.transform.position.x, 1,
               t * (point.z - cam.transform.position.z) + cam.transform.position.z);
           //Rotating the object to that point
           transform.LookAt(finalPoint, Vector3.up);
       }*/
     /*private void Update()
     {
         Vector3 input = Input.mousePosition;
         Vector3 mousePosition = camera.ScreenToWorldPoint(new Vector3(input.x, input.y, camera.transform.position.y));
         transform.LookAt(mousePosition + Vector3.up * transform.position.y);
     }*/
}
