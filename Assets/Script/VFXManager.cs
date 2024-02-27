using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
    public GameObject vfxAudio;


    public void playVFX(Vector3 spawnposition)
    {
        GameObject.Instantiate(vfxAudio, spawnposition, Quaternion.identity);
    }
}
