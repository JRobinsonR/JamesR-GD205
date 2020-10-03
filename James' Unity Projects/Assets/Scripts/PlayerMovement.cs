using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Change warps to tags for warps. 
    public Vector3 pos = new Vector3(5f, 10f, 15f);
    public Transform playerPiece;
    public Transform Camera;
    int index1A;
    int index1B;
    int index2A;
    int index2B;
    int index3A;
    int index3B;
    private GameObject[] warpR;
    private Transform[] warpR2;
    private GameObject[] warpW;
    private Transform[] warpW2;
    private GameObject[] landing;
    private Transform[] landingTF;
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
    public AudioClip collected;
    AudioSource myAud;

    // Start is called before the first frame update
    void Start()
    {
        playerStart = playerPiece.position;
        myAud = GetComponent<AudioSource>();
        warpR = GameObject.FindGameObjectsWithTag("WarpR");
        warpR2 = new Transform[warpR.Length];
        warpW = GameObject.FindGameObjectsWithTag("Warp");
        warpW2 = new Transform[warpW.Length];
        landing = GameObject.FindGameObjectsWithTag("Landing");
        index1A = Random.Range(0, landing.Length);
        index1B = Random.Range(0, landing.Length);
        index2A = Random.Range(0, warpR.Length);
        index2B = Random.Range(0, warpR.Length);
        index3A = Random.Range(0, warpW.Length);
        index3B = Random.Range(0, warpW2.Length);
        landingTF = new Transform[landing.Length];
    }

    // Update is called once per frame
    void Update()
    {
        for(int index1B = 0; index1B < landing.Length; index1B++)
        {
            landingTF[index1B] = landing[index1B].transform;
        }

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
        }


        if (playerPiece.position == warpR2[].position)
        {

        }
            if (playerPiece.position == PlayerGoal.position)
        {
            myAud.PlayOneShot(winner, 1f);
            playerMsg.text = "You Win!!!";
        }
    }
    //void OnCollisionEnter(Collision collision)
    //{
        //if (collision.gameObject.CompareTag("Warp"))
        //{
            //playerPiece.position = playerStart;
            //playerMsg.text = "Try Again";
            //myAud.PlayOneShot(wrong, 1f);
        //}
        //if (collision.gameObject.CompareTag("WarpR"))
        ////{
           // Vector3 position = landingTF[index2].position;
           // playerPiece.position = position;
        //}
    //}
}