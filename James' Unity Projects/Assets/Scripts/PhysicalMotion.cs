using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicalMotion : MonoBehaviour
{
    
    public float[] Keys;
    public float[] Enemies;
    public float oForce = 250f;
    public Transform Camera;
    public Rigidbody playerPiece;
    public TextMesh playerStat;
    AudioSource RollAud;
    public AudioClip Dead;
    public AudioClip Winner;

    void Start()
    {
        playerPiece = GetComponent<Rigidbody>();
        RollAud = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        Camera.position = playerPiece.position + new Vector3(-25f, 10f, 0f);
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (GetComponent<Rigidbody>() != null)
            {
                playerPiece.AddForce(new Vector3(0f, 0f, -3f) * oForce);
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (GetComponent<Rigidbody>() != null){
            playerPiece.AddForce(new Vector3(0f, 0f, 3f) * oForce);
        }
            
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (GetComponent<Rigidbody>() != null) {
            playerPiece.AddForce(new Vector3(5f, 0f, 0f) * oForce);
            }
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (GetComponent<Rigidbody>() != null)
            {
                playerPiece.AddForce(new Vector3(-5f, 0f, 0f) * oForce);
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (GetComponent<Rigidbody>() != null){
            playerPiece.AddForce(new Vector3(0f, 50f, 0f) * oForce);
            }
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            if (GetComponent<Rigidbody>() != null)
            {
                playerPiece.AddForce(new Vector3(0f, -550f, 0f) * oForce);
            }
        }
    }

    void OnCollisionEnter(Collision grab)
    {
        if (grab.gameObject.CompareTag("Key"))
        {

            Destroy(grab.gameObject);
        }

    }
    void OnDestroy()
    {
        
            playerStat.text = "DEAD";
        
        
        
    }

}