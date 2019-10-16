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
        Camera.position = playerPiece.position + new Vector3(6f, 39f, 1f);
    }

}