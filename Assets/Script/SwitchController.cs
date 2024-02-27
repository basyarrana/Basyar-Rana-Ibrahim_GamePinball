using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour
{
    private enum SwitchState
    {
        Off,
        On,
        Blink,
    }
    public Collider bola;
    public Material onmaterial;
    public Material offmaterial;

    
    public ScoreManager scoreManager;
    public float score;


    private SwitchState state;
    private Renderer render;

    private void Start() 
    {
        render = GetComponent<Renderer>();

        Set(false);
        StartCoroutine(BlinkTimerStart(5));
    }


   private void OnTriggerEnter(Collider other) 
   {
        if (other == bola)
        {
            Toggle();
        }
   }

   private void Set(bool active)
   {
        if (active == true)
        {
            state = SwitchState.On;
            render.material = onmaterial;
            StopAllCoroutines();
        }
        else 
        {
            state = SwitchState.Off;
            render.material = offmaterial;
            StartCoroutine(BlinkTimerStart(5));

            //addscore
            scoreManager.AddScore(score);
        }
   }

   private void Toggle()
   {
        if (state == SwitchState.On)
        {
            Set(false);
        }
        else 
        {
            Set(true);
        }
        
   }

   private IEnumerator Blink(int times)
   {
        state = SwitchState.Blink;

        for (int i = 0; i < times; i++)
        {
            render.material = onmaterial;
            yield return new WaitForSeconds(0.5f);
            render.material = offmaterial;
            yield return new WaitForSeconds(0.5f);
        }

        state = SwitchState.Off;

        StartCoroutine(BlinkTimerStart(5));

   }

   private IEnumerator BlinkTimerStart(float time)
   {
        yield return new WaitForSeconds(time);
        StartCoroutine(Blink(2));
   }

}
