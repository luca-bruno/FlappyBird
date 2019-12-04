using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour {

    public float maxTime = 1;
    private float timer = 0;
    public GameObject Pipe_Game_Object;
    public float height;

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        if(timer > maxTime){
            GameObject newpipe = Instantiate(Pipe_Game_Object); //spawn pipe set
            newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height));
            Destroy(newpipe, 15); //remove pipe 15s post-spawn
            timer = 0; //reset timer
        }
        
        timer += Time.deltaTime;
    }

    
}
