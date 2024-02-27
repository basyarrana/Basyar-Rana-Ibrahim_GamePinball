using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverTrigger : MonoBehaviour
{
    public Collider bola;
    public GameObject gameoverCanvas;

   private void OnTriggerEnter(Collider other) 
   {
        if (other == bola)
        {
            gameoverCanvas.SetActive(true);
        }
   }
    
}
