using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    //variables:
    public float playerSpeed;




    void OnTriggerStay2D(Collider2D collision)
    {
       // Debug.Log(collision.gameObject.name);
    }

    void Start()
    {
        //Debug.Log("started");
    }

    

    void Update()
    {
        
        
        
        //movement:
         if (Input.GetKey(KeyCode.W))
        {
            this.transform.position += new Vector3(0, playerSpeed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            this.transform.position += new Vector3(0, -playerSpeed * Time.deltaTime, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position += new Vector3(playerSpeed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position += new Vector3(-playerSpeed * Time.deltaTime, 0, 0);
        }

    }
}
