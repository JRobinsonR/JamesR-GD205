using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicalMotion : MonoBehaviour
{
    public Rigidbody Anvil;
     public float[] Keys;
     public float[] Arrays;
    public float oForce = 125f;
    public Transform Camera;
    public Rigidbody playerPiece;



    private void Start()
    {
       playerPiece = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void Update()
    {
        Camera.position = playerPiece.position + new Vector3(-25f, 10f, 0f);
        if (Input.GetKey(KeyCode.RightArrow))
        {
            
            playerPiece.AddForce(new Vector3(0f, 0f, -1f) * oForce);

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            playerPiece.AddForce(new Vector3(0f, 0f, 1f)* oForce);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            playerPiece.AddForce(new Vector3(1f, 0f, 0f) * oForce);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            playerPiece.AddForce(new Vector3(-1f, 0f, 0f) * oForce);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        { 
        //if(){
            playerPiece.AddForce(new Vector3(0f, 50f, 0f) * oForce);
            //}
        }
    }

}