using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float verticalInput;
    public float speed = 15.0f;
    public float xRange = 10.0f;
    public float leftRange = 25.0f;
    public float rightRange = 0.0f;
    

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Restrictions of player
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.z < -leftRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -leftRange);
        }

        if (transform.position.z > rightRange)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, rightRange);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

            verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * -verticalInput * Time.deltaTime * speed);

        //lauching projectile
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
