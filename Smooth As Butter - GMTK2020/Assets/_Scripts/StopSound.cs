using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopSound : MonoBehaviour
{
    private AudioSource source;
    private bool playing = false;

    [SerializeField] private string trickName;
    [SerializeField] private int score;

    private void Start()
    {
        StartCoroutine(SoundRoutine());
        source = GetComponent<AudioSource>();
    }

    public void TriggerStop()
    {
        if (playing == true)
        {
            if (trickName != "")
                TrickManager._instance.AddTrick(trickName, score);

            source.Stop();
            playing = false;

            StopAllCoroutines();
            StartCoroutine(SoundRoutine());
        }
    }

    private IEnumerator SoundRoutine()
    {
        yield return new WaitForSeconds(Random.value * 360 + 5);
        source.Play();
        playing = true;
    }
}
