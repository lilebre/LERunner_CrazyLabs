using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nostalgia : MonoBehaviour
{
    public AudioSource nostalgia;
    void Start()
    {
        nostalgia = GetComponent<AudioSource>();
    }

    public void nostalgiaOn()
    {
        nostalgia.volume = 0.5f;
        nostalgia.Play();
    }

    public void nostalgiaOff()
    {
        nostalgia.Stop();
    }

}
