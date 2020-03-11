using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Transform playerBit;
    public float movement;
    public Vector3 playerStart;
    public Transform cam;
    

    // Start is called before the first frame update
    void Start()
    {
        playerStart = playerBit.position;
       
        
    }

    // Update is called once per frame
    void Update()
    {
        cam.position = playerBit.position + new Vector3(0, 17, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerBit.transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * movement;

        }
        if (Input.GetKeyDown(KeyCode.W)) {

            playerBit.position += new Vector3(0, 0, movement);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {

            playerBit.position += new Vector3(0, 0, -movement);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {

            playerBit.position += new Vector3(-movement, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {

            playerBit.position += new Vector3(movement, 0,0);
        }
    }
}
