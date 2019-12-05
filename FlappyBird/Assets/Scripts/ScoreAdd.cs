using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAdd : MonoBehaviour
{
    //public AudioSource scoreSound;
    private void OnTriggerEnter2D(Collider2D collision){
    //scoreSound.Play();
    SoundManager.PlaySound("score_Sound");
    Score.score++;
    }  
    }

    