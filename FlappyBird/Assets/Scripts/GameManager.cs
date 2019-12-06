using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject startCanvas;
    public GameObject scoreCanvas;
    public GameObject gameOverCanvas; //UI defined
    private bool started = false; //variable for keeping record if game has commenced (left-click start functionality)

    private void Start() {
        Time.timeScale = 0; //gameplay frozen
        startCanvas.SetActive(true); //start UI displayed
        scoreCanvas.SetActive(false); //score UI hidden
        gameOverCanvas.SetActive(false); //game over UI hidden
    }    

    void Update() {
        if(started == false) {
            if(Input.GetMouseButtonDown(0)){
                Time.timeScale = 1; //gameplay resumed
                startCanvas.SetActive(false); //start UI hidden
                scoreCanvas.SetActive(true); //score UI displayed
                started = true;
            }
    }
}

    public void GameOver(){
        gameOverCanvas.SetActive(true); //game over UI displayed
        scoreCanvas.SetActive(false); //score UI hidden
        Time.timeScale = 0; //gameplay frozen
    }
}
