﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] AudioSource audioSourceBGM;
    [SerializeField] AudioSource audioSourceSE;
    [SerializeField] AudioClip[] bgmList;
    [SerializeField] AudioClip[] seList;

    public enum SE
    {
        Correct,
        Wrong,
        Finish,

    }

    public enum BGM
    {
        Title,
        Main

    }

    public static SoundManager instance;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        PlayBGM(BGM.Main);


    }

    public void PlayBGM(BGM bgm)
    {
        int index = (int)bgm;
        audioSourceBGM.clip = bgmList[index];
        audioSourceBGM.Play();
    }

    public void PlaySE(SE se)
    {
        int index = (int)se;
        Debug.Log(index);
        Debug.Log(seList[index]);
        Debug.Log(audioSourceSE);
        audioSourceSE.PlayOneShot(seList[index]);
    }

    public void StopBGM()
    {
        audioSourceBGM.Stop();
    }
}
