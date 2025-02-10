using System;
using UnityEngine;
using UnityEngine.Audio;

public class Wall : MonoBehaviour
{
    public AudioSource sound;


    void OnTriggerEnter2D(Collider2D collision)
    {
        sound.Play();
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
