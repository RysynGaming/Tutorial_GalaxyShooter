using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private float baseSpeed = 10f;

    void Start ()
    {
        Debug.Log(this.tag + " has spawned!");
        transform.position = new Vector3(0, 0, 0);
	}
	
	void Update ()
    {

        movement();

    }

    private void movement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * Time.deltaTime * baseSpeed * horizontalInput);
        transform.Translate(Vector3.up * Time.deltaTime * baseSpeed * verticalInput);

        if (transform.position.x > 9f)
        {
            transform.position = new Vector3(9f, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -9f)
        {
            transform.position = new Vector3(-9f, transform.position.y, transform.position.z);
        }

        if (transform.position.y > 2f)
        {
            transform.position = new Vector3(transform.position.x, 2f, transform.position.z);
        }
        else if (transform.position.y < -5f)
        {
            transform.position = new Vector3(transform.position.x, -5f, transform.position.z);
        }

    }
}
