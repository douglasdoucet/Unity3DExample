using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class DoorOpenBehavior : MonoBehaviour
{
    public GameObject timeLine;
    PlayableDirector director;

    // Start is called before the first frame update
    void Start()
    {
        director = timeLine.GetComponent<PlayableDirector>();
    }

    void OnTriggerEnter(Collider other){
        if (other.CompareTag("Player")){
            print("Playing");
            director.Play();
        }
    }

    void OnTriggerExit(Collider other){
        if (other.CompareTag("Player")){
            director.Stop();
        }
    }
}
