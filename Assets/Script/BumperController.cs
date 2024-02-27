using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperController : MonoBehaviour
{
    public Collider bola;
    public float mulltiplier;
    public Color  color;
    public float score;


    public AudioManager audioManager; 
    public VFXManager vfxManager;
    public ScoreManager scoreManager;


    private Renderer render;
    private Animator animator; 




    private void Start() 
    {
        render = GetComponent<Renderer>();
        animator = GetComponent<Animator>();

        render.material.color = color;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == bola)
        {
            Rigidbody BolaRig = bola.GetComponent<Rigidbody>();
            BolaRig.velocity *= mulltiplier;

            //animasiin
            animator.SetTrigger("hit");

            //playsfx
            audioManager.playSFX(collision.transform.position);

            //playvfx
            vfxManager.playVFX(collision.transform.position);

            //score add
            scoreManager.AddScore(score);
            


        }
    }
}
