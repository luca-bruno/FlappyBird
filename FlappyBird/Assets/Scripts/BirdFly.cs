using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdFly : MonoBehaviour {

    public GameManager gameManager;
    public float velocity = 2f;
    private Rigidbody2D rb; 
    public AudioSource deathSound;
    public AudioSource jumpSound;

    void Start(){
        rb = GetComponent<Rigidbody2D>();
    }

    void Update(){
        if (Input.GetMouseButtonDown(0)){
            //jump
            rb.velocity = Vector2.up * velocity;
            jumpSound.Play();
        }
    }
    
    private void OnCollisionEnter2D(Collision2D collision){
        gameManager.GameOver();
        deathSound.Play();
    }

}

