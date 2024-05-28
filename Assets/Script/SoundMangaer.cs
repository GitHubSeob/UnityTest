using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundMangaer : MonoBehaviour
{    
    AudioSource bgm;

    private void Awake()
    {
        
        bgm = GameObject.Find("SoundManager").GetComponent<AudioSource>();
        if (bgm.isPlaying) return;
        else
        {
            bgm.Play();
            DontDestroyOnLoad(bgm);
        }
    }
}
