using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PredatorMovement : MonoBehaviour
{
    public float[] Seeker;
    public Transform target;
    Rigidbody Enemy;
    
    // Start is called before the first frame update
    void Start()
    {
        Enemy = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (target) {
            Vector3 targetDir = Vector3.Normalize(target.position - transform.position);
            Enemy.AddForce(targetDir * 50f);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if( collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
            
        }

        
    }
    
}
