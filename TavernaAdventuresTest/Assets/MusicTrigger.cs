using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicTrigger : MonoBehaviour
{

    public AudioClip outside;
    public AudioClip inside;
    
    public AudioSource source;
    public CapsuleCollider player;
    // Start is called before the first frame update
    void Start()
    {
        
        
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    private void OnTriggerEnter(Collider collide) {

        if(collide == player) {
            source.Stop();
            source.clip = inside;
            source.Play();
        }

    }

    private void OnTriggerExit(Collider collide) {
         if(collide == player) {
            source.Stop();
            source.clip = outside;
            source.Play();
        }
    }

}
