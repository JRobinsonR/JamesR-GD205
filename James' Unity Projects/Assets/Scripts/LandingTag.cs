using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LandingTag : MonoBehaviour
{
    public GameObject[] LandTagArray;
    public string tagName;

    // Start is called before the first frame update
    void Start()
    {
        LandTagArray = GameObject.FindGameObjectsWithTag("Landing");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
