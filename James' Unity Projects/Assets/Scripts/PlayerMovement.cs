using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Change warps to tags for warps. 
    public Vector3 pos = new Vector3(5f, 10f, 15f);
    public Transform playerPiece;
    public Transform Camera;
    public Transform warpR, warpW;
    public Transform Key;
    bool hasKey = false;
    public Transform Obstacle;
    public Transform PlayerGoal;
    public Vector3 playerStart;
    public TextMesh playerMsg;
    public float tileAmount = 5f;
    public AudioClip wrong;
    public AudioClip right;
    public AudioClip winner;
    AudioSource myAud;

    // Start is called before the first frame update
    void Start()
    {
        playerStart = playerPiece.position;
        myAud = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        Camera.position = playerPiece.position + new Vector3(6f, 39f, 1f);

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (Obstacle.position != playerPiece.position + new Vector3(0f, 0f, tileAmount))
            {
                //modify the playerPiece position by tileAmount on the z axis
                playerPiece.position += new Vector3(0f, 0f, tileAmount);
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (Obstacle.position != playerPiece.position + new Vector3(0f, 0f, -tileAmount))
            {
                //modify the playerPiece position by tileAmount on the z axis
                playerPiece.position += new Vector3(0f, 0f, -tileAmount);
            }
        }
        
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (Obstacle.position != playerPiece.position + new Vector3(tileAmount, 0f, 0f))
            {
                //modify the playerPiece position by tileAmount on the x axis
                playerPiece.position += new Vector3(tileAmount, 0f, 0f);
            }
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (Obstacle.position != playerPiece.position + new Vector3(-tileAmount, 0f, 0f))
            {
                //modify the playerPiece position by tileAmount on the x axis
                playerPiece.position += new Vector3(-tileAmount, 0f, 0f);
            }
        } //Need help modifying collisions so half the sphere doesn't go in before it stops.

        if (playerPiece.position == warpW.position) //Please leave me an example of an array text for several objects. Thank you!
        {
            playerPiece.position = playerStart;

            //the matching sound would go here, but I couldn't add it in.
            playerMsg.text = "Try Again";
            myAud.PlayOneShot(wrong, 1f);

        }

        if (playerPiece.position == warpR.position) //Please leave me an example of an array text for several objects. Thank you!
        {
            
            myAud.PlayOneShot(right, 1f);
            playerPiece.position = new Vector3(520f, 30f, -96f);

            playerMsg.text = "Good Job!";

        }
        if (playerPiece.position == PlayerGoal.position)
        {

        }
            if (playerPiece.position == PlayerGoal.position)
        {
            myAud.PlayOneShot(winner, 1f);
            playerMsg.text = "You Win!!!";
        }
    }
}