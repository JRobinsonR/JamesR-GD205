using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserRay : MonoBehaviour
{
    public float impactAmount = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit = new RaycastHit();
        Debug.DrawRay(laser.origin, laser.direction * impactAmount, Color.red);
        if (Physics.Raycast(laser, out hit, 100f)) {

            Debug.Log("Impact" + hit.transform.gameObject.name + "detected");
            if (hit.rigidbody && Input.GetMouseButton(0))
            {
                Vector3 whichDirection = Random.insideUnitSphere;
                hit.rigidbody.AddForce(Vector3.up * impactAmount);
            }
        }
    }
}
