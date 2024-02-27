using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource bgmAudio;
    public GameObject sfxAudio;

    void Start()
    {
        playBGM();
    }

    private void playBGM()
    {
        bgmAudio.Play();
    }

    public void playSFX(Vector3 spawnposition)
    {
        GameObject.Instantiate(sfxAudio, spawnposition, Quaternion.identity);
    }
}
