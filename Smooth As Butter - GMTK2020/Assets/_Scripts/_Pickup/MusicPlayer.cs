using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    private AudioSource source;
    [SerializeField] private AudioClip[] sounds = new AudioClip[0];
    private int index = 0;

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    public void SwitchSound()
    {
        if (index == -1)
        {
            source.Stop();
        }
        else
        {
            source.clip = sounds[index];
            source.Play();
        }

        index++;
        if (index == sounds.Length)
            index = -1;
    }
}
