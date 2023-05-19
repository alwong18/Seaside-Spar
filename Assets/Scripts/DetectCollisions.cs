using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private PlayerController playerControllerScript;
    private GameManager gameManager;

    public int pointValue;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Destroy objects on collision
    private void OnTriggerEnter(Collider other)
    {
        gameManager.UpdateScore(pointValue);
        Destroy(gameObject);

        if(gameObject.CompareTag("Enemy"))
        {
            gameManager.GameOver();
            Debug.Log("Game Over");
        }
    }
}
