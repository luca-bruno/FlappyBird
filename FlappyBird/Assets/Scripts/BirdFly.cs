using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdFly : MonoBehaviour {

    public GameManager gameManager;
    public float velocity = 2f;
    private Rigidbody2D rb; 
    public AudioSource deathSound;

    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }

    void Update(){
        if (Input.GetMouseButtonDown(0)){
            //jump
            rb.velocity = Vector2.up * velocity;
       //     audio.PlayOneShot (flapping);
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision){
        gameManager.GameOver();
        deathSound.Play();
    }

}

