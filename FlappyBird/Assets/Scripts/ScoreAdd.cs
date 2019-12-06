using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreAdd : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision){
    SoundManager.PlaySound("score_Sound"); //score sound upon collision
    Score.score++; //increments score
    }  
    }

    