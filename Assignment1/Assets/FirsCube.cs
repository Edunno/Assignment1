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
        if(Input.GetKey(KeyCode.A)){
            float camF = RunCam();
            this.GetComponent<Rigidbody>().AddForce(-20-(40*camF),0,camF*20);
        }
        if(Input.GetKey(KeyCode.D)){
            float camF = RunCam();
            this.GetComponent<Rigidbody>().AddForce(20+(40*camF),0,camF*20);
        }
        if(Input.GetKey(KeyCode.W)){
            float camF = RunCam();
            this.GetComponent<Rigidbody>().AddForce(camF*20,0,20*camF);
        }
        if(Input.GetKey(KeyCode.S)){
            float camF = RunCam();
            this.GetComponent<Rigidbody>().AddForce(camF*-20,0,-20*camF);
        }
    }
    float RunCam()
    {
        float camB;
        float camY = pCam.transform.rotation.y;
        if(camY>360||camY<-360){
            camY = (camY%360);
        }
        print("first:"+camY);
        if(camY>0){
            camB = 1-camY;
        }
        else{
            camB = camY;
        }
        print(camB);
        return camB;
    }
}
