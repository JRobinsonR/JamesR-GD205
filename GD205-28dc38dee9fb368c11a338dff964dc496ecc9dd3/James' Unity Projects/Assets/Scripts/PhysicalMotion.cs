using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicalMotion : MonoBehaviour
{
    public Rigidbody Anvil;
    public float oForce = 100f;
    public Transform Camera;
    public Transform playerPiece;



    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        Camera.position = playerPiece.position + new Vector3(-25f, 10f, 0f);
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            playerPiece.position += new Vector3(0f, 0f, -1f);

            //playerPiece.rotation += new Vector3(0f, 0f, -1f);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            playerPiece.position += new Vector3(0f, 0f, 1f);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            playerPiece.position += new Vector3(1f, 0f, 0f);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            playerPiece.position += new Vector3(-1f, 0f, 0f);
        }
    }

}