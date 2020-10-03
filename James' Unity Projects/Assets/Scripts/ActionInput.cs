             using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionInput : MonoBehaviour
{
    float Value = 0.3f;
    Animator myAnim;
    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
        myAnim.SetFloat("MotionParameter", Value);
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKey(KeyCode.UpArrow)) {

            myAnim.SetFloat("MotionParameter", 0.8f);

        }
       if(Input.GetKeyUp(KeyCode.UpArrow))
        {
            myAnim.SetFloat("MotionParameter", Value);
        }
    }
}
