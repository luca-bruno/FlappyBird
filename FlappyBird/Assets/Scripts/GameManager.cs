using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject startCanvas;
    public GameObject scoreCanvas;
    public GameObject gameOverCanvas;
    private bool started = false;

    private void Start() {
        Time.timeScale = 0;
        startCanvas.SetActive(true);
        scoreCanvas.SetActive(false);
        gameOverCanvas.SetActive(false);
    }    

    void Update() {
        if(started == false) {
            if(Input.GetMouseButtonDown(0)){
                Time.timeScale = 1;
                startCanvas.SetActive(false);
                scoreCanvas.SetActive(true);
                started = true;
            }
    }
}

    public void GameOver(){
        gameOverCanvas.SetActive(true);
        scoreCanvas.SetActive(false);
        Time.timeScale = 0;
    }
}
