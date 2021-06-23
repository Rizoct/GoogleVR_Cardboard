using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoScript : MonoBehaviour
{
    public VideoPlayer _video;

    public void btn_presse(int id){
        if(id == 0){
            _video.Play();
        }
        if(id == 1){
            _video.Pause();
        }
    }
}
