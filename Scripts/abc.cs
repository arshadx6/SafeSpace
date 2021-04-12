using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
public class abc : MonoBehaviour
{   public GameObject LabelName;
    private VideoPlayer video;
    Text label;
    // Start is called before the first frame update
    void Start()
    {
         
        label=LabelName.GetComponent<Text>();

    }
    

    // Update is called once per frame
    void Update()
    {
            if (label != null)
            if(label.Equals("Cube"))
            {
                video.Stop();
          
            }
    }
}
