using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coffee : MonoBehaviour
{   public GameObject cylinder;
    public AudioSource aud;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if((Input.GetTouch(0).phase == TouchPhase.Began))
        { 
        	Ray ray=Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
        	RaycastHit hit;
        	if(Physics.Raycast(ray,out hit)){
                if(hit.transform.name=="Capsule"){
                    cylinder.transform.localScale=new Vector3(0.13f,0.12f,-0.09f);
                    aud.Play();
                }
                
        	}
        }
    }
}
