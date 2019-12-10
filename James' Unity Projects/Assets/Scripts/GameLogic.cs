using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    public float timeElapsed = 0;
    public Transform playerPiece;
    public TextMesh playerMsg;
    public Vector3 playerStart;
    AudioSource myAud;
    public AudioClip wrong;
    public AudioClip right;
    public AudioClip winner;
    public AudioClip collected;
    public List<GameObject> BadTeleporters;
    public List<GameObject> GoodTeleporters;
    public List<GameObject> landings;

    // Start is called before the first frame update
    void Start()
    {
        playerStart = playerPiece.position;
    }

    void Update()
    {
        timeElapsed += Time.deltaTime;
        Debug.Log(timeElapsed);

        foreach(GameObject BadTeleporter in BadTeleporters)
        {
            void OnCollisionEnter(Collision BadLuck)
            {
                if (BadLuck.gameObject.name == "Player")
                {
                    playerPiece.position = playerStart;
                    playerMsg.text = "Try Again";
                    myAud.PlayOneShot(wrong, 1f);
                }
            }

        }
        //foreach(GameObject GoodTeleporter in GoodTeleporters)
        //{
        //    void OnCollisionEnter (Collision Goodluck)
        //    {
        //        if(Goodluck.gameObject.name = "Player")
        //        {
        //            playerPiece.position =;
        //        }
        //    }
        //}
    }
}
