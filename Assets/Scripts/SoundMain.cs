using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundMain : MonoBehaviour
{
    public AudioClip CubeHighlightSound;

    public void PlayCubeHighlightSound()
    {
        AudioSource source = gameObject.AddComponent<AudioSource>();

        source.clip = CubeHighlightSound;

        source.Play(0);
    }
}
