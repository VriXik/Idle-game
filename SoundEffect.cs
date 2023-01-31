using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffect : MonoBehaviour
{
    public AudioSource soundPlayer;

    public void VFX()
    {
        soundPlayer.Play();
    }
}
