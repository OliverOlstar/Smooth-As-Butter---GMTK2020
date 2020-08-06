using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone : MonoBehaviour
{
    private bool Call = false;
    [SerializeField] private AudioSource source;
    [SerializeField] private AudioClip ring;
    [SerializeField] private AudioClip talking;

    void Start()
    {
        StartCoroutine(CallDelay());
    }

    private IEnumerator CallDelay()
    {
        while (true)
        {
            yield return new WaitForSeconds(240f);

            Call = true;
            source.clip = ring;

            while (Call)
            {
                source.Play();
                yield return new WaitForSeconds(3f);
            }
        }
    }

    public void Grabbed()
    {
        if (Call)
        {
            Call = false;
            TrickManager._instance.AddTrick("MESSAGE RECIEVED", 1000000);

            source.clip = talking;
            source.Play();
        }
    }
}
