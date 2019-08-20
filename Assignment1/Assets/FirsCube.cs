using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirsCube : MonoBehaviour
{
    public Camera pCam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    //Prøvede at få retningerne til at følge kameraets retning, men det lykkedes ikke :(
    {
        int velocity = 10;
        if(Input.GetKey(KeyCode.A)){
            Vector3 camF =  RunCam();
            this.GetComponent<Rigidbody>().AddForce(camF*velocity*-1);
        }
        if(Input.GetKey(KeyCode.D)){
            Vector3 camF =  RunCam();
            this.GetComponent<Rigidbody>().AddForce(camF*velocity);
        }
        if(Input.GetKey(KeyCode.W)){
            Vector3 camF = RunCamHoriz();
            this.GetComponent<Rigidbody>().AddForce(camF*velocity);
        }
        if(Input.GetKey(KeyCode.S)){
            Vector3 camF = RunCamHoriz();
            this.GetComponent<Rigidbody>().AddForce(camF*velocity*-1);
        } 
    }

    Vector3 RunCamHoriz()
    {
        Vector3 camY = Camera.main.transform.forward;
        return camY;
    }

    Vector3 RunCam()
    {
        Vector3 camY = Camera.main.transform.right;
        print(camY);
        return camY;
    }
}
