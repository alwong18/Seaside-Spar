using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Destroy objects on collision
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }

    //Game ends when bomb hits turtle
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            playerControllerScript.collisionParticle.Play();
            
            /*Debug.Log("Game Over");
            playerControllerScript.gameOver = true;*/
        }
    }
}
