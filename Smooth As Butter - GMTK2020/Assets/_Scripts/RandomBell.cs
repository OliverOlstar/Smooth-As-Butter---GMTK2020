using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBell : MonoBehaviour
{
    private AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        StartCoroutine(Loop());
    }

    private IEnumerator Loop()
    {
        while (true)
        {
            yield return new WaitForSeconds(1 + Random.value * 600);
            source.Play();
            source.pitch = Random.value * 0.2f + 0.9f;
        }
    }
}
