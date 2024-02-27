using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomInTriggerController : MonoBehaviour
{
    
    public Collider bola;
    public CameraController cameraController;
    public float lenght;
   private void OnTriggerEnter(Collider other) 
   {
        if (other == bola)
        {
            cameraController.FollowTarget(bola.transform, lenght);
        }
   }
}
