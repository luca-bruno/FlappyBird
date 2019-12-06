using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour {

    public float maxTime = 1;
    private float timer = 0;
    public GameObject Pipe_Game_Object;
    public float height;

    void Start(){
        
    }

    void Update(){
        if(timer > maxTime){
            GameObject newpipe = Instantiate(Pipe_Game_Object); //spawn set of pipes
            newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height)); //determining random height of new pipe spawned
            Destroy(newpipe, 15); //removes pipe 15 second post-spawn
            timer = 0; //resets timer for new pipe to spawn
        }
        
        timer += Time.deltaTime;
    }

    
}
