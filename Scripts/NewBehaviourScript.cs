using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{	private Text label;
    // Start is called before the first frame update
    void Start()
    {
        label = GameObject.Find("LabelName").GetComponent<Text>();
        label.text="";
        
    }

    // Update is called once per frame
    void Update()
    {   
        if((Input.GetTouch(0).phase == TouchPhase.Began))
        {
        	Ray ray=Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
        	RaycastHit hit;
        	if(Physics.Raycast(ray,out hit)){
        		label.text=hit.transform.name.ToString();

        	}
        	else{
        		label.text="";
        	}
        }
    }
}
