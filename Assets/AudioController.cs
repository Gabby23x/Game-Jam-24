using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    private AudioSource audioSource = new AudioSource();
    public List<AudioClip> SFX;
    
    public void playSound(int idx)
    {
        if (SFX != null && 0 <= idx && idx < SFX.Count && SFX[idx] != null)
        {
            // only works for one clip at a time probably but should be fine?
            audioSource.clip = SFX[idx];
            audioSource.Play();
        }
    }
}
