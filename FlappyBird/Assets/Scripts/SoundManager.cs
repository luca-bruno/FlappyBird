using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    
    public static AudioClip score_Sound;
    static AudioSource src;
    void Start(){
    score_Sound = Resources.Load<AudioClip> ("score_Sound"); //loads score_Sound from folder because of ScoreAdd script in prefab
        
    src = GetComponent<AudioSource>();

    }

    void Update()
    {
        
    }

    public static void PlaySound (string clip){
        switch (clip){
            case "score_Sound":
            src.PlayOneShot(score_Sound); //loads score sound into variable referenced in ScoreAdd class
            break;
        }
    }
}
