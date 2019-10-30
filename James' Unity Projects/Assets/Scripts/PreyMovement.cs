using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreyMovement : MonoBehaviour
{
    public float[] Collect;
    public Transform target;
    Rigidbody Key;
    public TextMesh playerStat;
    // Start is called before the first frame update
    void Start()
    {
        Key = GetComponent<Rigidbody>();
        if(target == null)
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        if (target) { 
        Vector3 targetDir = Vector3.Normalize(target.position - transform.position);
        Key.AddForce(targetDir * -50f);
        }


    }

    void OnDestroy()
    {
        if (Key == null)
        {
            playerStat.text = "You Win!";
        }
    }
}

