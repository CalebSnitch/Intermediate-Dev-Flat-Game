using UnityEngine;
using UnityEngine.Audio;

public class Win : MonoBehaviour
{

    public AudioSource sound;

    void OnTriggerEnter2D(Collider2D collision)
    {
        sound.Play();
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
