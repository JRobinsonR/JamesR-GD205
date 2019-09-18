using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

public Vector3 pos = new Vector3(5f,10f,15f);
public Transform playerPiece;
public Transform warpR;
public Transform warpW;
public Vector3 playerStart;

    // Start is called before the first frame update
    void Start()
    {
         playerStart = playerPiece.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) 
        {
           
            //modify the playerPiece position by tileAmount on the z axis
            playerPiece.position += new Vector3(0f,0f, 5f);
    }
    if (Input.GetKeyDown(KeyCode.S)) 
        {
            
            //modify the playerPiece position by tileAmount on the z axis
            playerPiece.position += new Vector3(0f,0f, -5f);
        }
    if (Input.GetKeyDown(KeyCode.UpArrow)) 
        {
            
            //modify the playerPiece position by tileAmount on the z axis
            playerPiece.position += new Vector3(0f,5f, 0f);
            }
             if (Input.GetKeyDown(KeyCode.DownArrow)) {
           

            //modify the playerPiece position by tileAmount on the z axis
            playerPiece.position += new Vector3(0f,-5f, 0f);
        }
         
         if (Input.GetKeyDown(KeyCode.LeftArrow)) 
        {
            

            //modify the playerPiece position by tileAmount on the z axis
            playerPiece.position += new Vector3(5f,0f, 0f);
        }
         if (Input.GetKeyDown(KeyCode.RightArrow)) 
        {
            
            //modify the playerPiece position by tileAmount on the z axis
            playerPiece.position += new Vector3(-5f,0f, 0f);
        }
        if (playerPiece.position == warpW.position){
        playerPiece.position = playerStart;
        
        }
        }
}