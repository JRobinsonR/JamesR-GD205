using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

public Vector3 pos = new Vector3(5f,10f,15f);
public Transform playerPiece;
public Transform warpR, warpW;
public Transform obstacle;
public Transform RoadBlocks;
public Vector3 playerStart;
public TextMesh playerMsg;

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
           if(obstacle.position != playerPiece.position +new Vector3(0f,0f, 2.5f)){
            //modify the playerPiece position by tileAmount on the z axis
            playerPiece.position += new Vector3(0f,0f, .5f);
            }
    }
    if (Input.GetKeyDown(KeyCode.S)) 
        {
            if(obstacle.position != playerPiece.position +new Vector3(0f,0f, -2.5f)){
            //modify the playerPiece position by tileAmount on the z axis
            playerPiece.position += new Vector3(0f,0f, -.5f);
        }
        }
    if (Input.GetKeyDown(KeyCode.UpArrow)) 
        {
            if(obstacle.position != playerPiece.position +new Vector3(0f,2.5f, 0f)){
            //modify the playerPiece position by tileAmount on the z axis
            playerPiece.position += new Vector3(0f,.5f, 0f);
            }
            }
     if (Input.GetKeyDown(KeyCode.DownArrow)) {

        if(obstacle.position != playerPiece.position +new Vector3(0f,-2.5f, 0f)){
            //modify the playerPiece position by tileAmount on the z axis
            playerPiece.position += new Vector3(0f,-.5f, 0f);
        }
         }
     if (Input.GetKeyDown(KeyCode.LeftArrow)) 
        {
        if(obstacle.position != playerPiece.position +new Vector3(2.5f,0f, 0f)){
            //modify the playerPiece position by tileAmount on the z axis
            playerPiece.position += new Vector3(.5f,0f, 0f);
        }
        }
     if (Input.GetKeyDown(KeyCode.RightArrow)) 
        {
            if(obstacle.position != playerPiece.position +new Vector3(-2.5f,0f, 0f)){
            //modify the playerPiece position by tileAmount on the z axis
            playerPiece.position += new Vector3(-.5f,0f, 0f);
        }
        }
        
    if (playerPiece.position == warpW.position){
        playerPiece.position = playerStart;
        
        playerMsg.text = "Try Again";
        
        }
        }
}