using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sans : MonoBehaviour
{
    public AudioClip mega;
    AudioSource aud;
    int cou = 0;
    // Start is called before the first frame update
    void Start()
    {
        this.cou = 0;
        this.aud = GetComponent<AudioSource>();
        this.aud.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameDirector.ftime > 20 && cou == 0)
        {
            this.aud.Play();
            cou += 1;
        }

    }
}
