using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicTriggerTavern : MonoBehaviour
{

    public AudioClip wald;
    public AudioClip taverne;
    public AudioSource source;
    public bool changeMusic = true;
    public bool pls = true;
    public BoxCollider collider;
    public int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        source.clip = taverne;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        if(i == 120) {
            pls = true;
            i = 0;
        }
    }

    private void OnTriggerExit(Collider collide) {

if(pls) {
                 if(changeMusic) {
                
                source.Stop();
                source.clip = wald;
                source.Play();
                pls = false;

            } else {
                source.Stop();
                source.clip = taverne;
                source.Play();
                pls = false;

            }
        changeMusic = !changeMusic;
        i = 0;
}
    }

    private IEnumerator DelayedAction() {
    yield return new WaitForSeconds(1);
    collider.enabled = true;
    }
}
