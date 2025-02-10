using UnityEngine;
using UnityEngine.Audio;


public class Spike : MonoBehaviour
{
    public AudioSource sound;

    void OnCollisionEnter()
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
