using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class canvasscr : MonoBehaviour
{
    public Button b;
    public Text t;
    public Button Sb;
    public AudioSource s;
    public Button Ib;

    // Start is called before the first frame update
    void Start()
    {
        print("Hello World");
        t.text = "Click this";
        b.onClick.AddListener(WhenClicked);
        Sb.onClick.AddListener(PlaySound);
        Ib.onClick.AddListener(MakeObject);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F)){
            print("Respect");
        }
        
    }

    void WhenClicked()
    {
        t.text = "Click noted";
        print(t.text);
        //GamObject.Find("whatevs").GetComponent<Rigidbody>().AddForce(0,20,0);
    }

    void PlaySound()
    {
        s.Play();
    }

    void MakeObject()
    {
        Vector3 myVector = new Vector3(1.0f, 10.0f, 0.0f);
        GameObject instance = (GameObject) Instantiate(Resources.Load("Cube"),myVector,transform.rotation);
    }
}
