using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class music : MonoBehaviour
{   public AudioSource aud;
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
                if(aud.isPlaying && hit.transform.name=="music"){
                    aud.Stop();
                }
                else if(hit.transform.name=="music"){
                    aud.Play();
                }
                
                
        	}
        }
    }
}
