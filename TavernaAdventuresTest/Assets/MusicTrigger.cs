using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicTrigger : MonoBehaviour
{

    public BoxCollider tavernenCollider;
    public GameObject player;
    public AudioSource source;

    public AudioClip taverne;
    public AudioClip wald;
    public AudioClip traumland;
    public AudioClip klippenboss;

    // Start is called before the first frame update
    void Start()
    {
        source.clip = taverne;
        source.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider dick) {
        if(dick == tavernenCollider) {
            source.Stop();
            source.clip = wald;
            source.Play();
        }
    }
}
