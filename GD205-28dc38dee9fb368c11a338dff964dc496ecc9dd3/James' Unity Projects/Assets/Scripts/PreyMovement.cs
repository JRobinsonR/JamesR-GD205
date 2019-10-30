using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreyMovement : MonoBehaviour
{
    public float[] Collect;
    public Transform target;
    Rigidbody Key;
    public TextMesh playerWin;
    // Start is called before the first frame update
    void Start()
    {
        Key = GetComponent<Rigidbody>();
        if(target == null)
        {
            //target = GameObject.FindWithTag("Player");
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetDir = Vector3.Normalize(target.position - transform.position);
        Key.AddForce(targetDir * -50f);

       

    }

    void OnDestroy()
    {
        if (Key == null)
        {
            playerWin.text = "You Win!";
        }
    }
}

