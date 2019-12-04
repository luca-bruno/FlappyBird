using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject startCanvas;
    public GameObject gameOverCanvas;
    private bool started = false;

    private void Start() {
        Time.timeScale = 0;
        startCanvas.SetActive(true);
        gameOverCanvas.SetActive(false);
    }    

    void Update() {
        do {
            if(Input.GetMouseButtonDown(0)){
            Time.timeScale = 1;
            startCanvas.SetActive(false);
            started = true;
            }
    } while (started == false);
}

    public void GameOver(){
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }
}
