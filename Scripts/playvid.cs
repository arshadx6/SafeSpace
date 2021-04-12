using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class playvid : MonoBehaviour
{
    public UnityEngine.Video.VideoClip videoClip;

    void Start()
    {
        var videoPlayer = gameObject.AddComponent<UnityEngine.Video.VideoPlayer>();
        var audioSource = gameObject.AddComponent<AudioSource>();
        videoPlayer.playOnAwake = false;
        videoPlayer.clip = videoClip;
        videoPlayer.renderMode = UnityEngine.Video.VideoRenderMode.MaterialOverride;
        videoPlayer.targetMaterialRenderer = GetComponent<Renderer>();
        videoPlayer.targetMaterialProperty = "_MainTex";
        videoPlayer.audioOutputMode = UnityEngine.Video.VideoAudioOutputMode.AudioSource;
        videoPlayer.SetTargetAudioSource(0, audioSource);
    }

    
    void Update()
    {
        if((Input.GetTouch(0).phase == TouchPhase.Began))
        {   var vp = GetComponent<UnityEngine.Video.VideoPlayer>();
        	Ray ray=Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
        	RaycastHit hit;
        	if(Physics.Raycast(ray,out hit)){
                if(vp.isPlaying && hit.transform.name=="button1"){
                    vp.Stop();
                }
                else if(hit.transform.name=="button1"){
                    vp.Play();
                }
                
        	}
        }
    }
}
