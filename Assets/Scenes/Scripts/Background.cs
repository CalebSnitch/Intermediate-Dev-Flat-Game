using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Audio;

public class Background : MonoBehaviour
{
    public AudioSource sound;

   void OnTriggerEnter2D()
    {
        sound.Pause();
        Debug.Log("happened_1");
    }

    void OnTriggerExit2D()
    {
        sound.Play();
        Debug.Log("happened");
    }


    



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
