using System.Threading;
using System.Diagnostics;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArenaSkript : MonoBehaviour
{

    public AudioClip outside;
    public AudioClip insideArena;
    public AudioSource source;
    public int GegnerAnzahl;
    public GameObject player;

    public GameObject enemy;
    // Start is called before the first frame update

    private System.Random r = new System.Random();

    private int x = 753;
    private int y = 50;
    private int z = 710;
    public int counterGegner = 0;
    public int spawnRate = 0;
    public int spawnRateTwo;
    void Start()
    {
        spawnRateTwo  = r.Next(200,500);
    }

    // Update is called once per frame
    void Update()
    {
        if(called) {

            UnityEngine.Debug.Log("Aufgerufen");
            

            if(counterGegner < GegnerAnzahl) {

                spawnRate++;
                
                if(spawnRate == spawnRateTwo) {
                    int posx = r.Next(2) * 2 - 1;
                    

                    //x +-25
                    //y+- 25
                    int randomx = x + (r.Next(25) * posx);
                    int randomz = z + (r.Next(25) * -1);
                    Instantiate(enemy, new Vector3(randomx, y, randomz), Quaternion.identity);
                    counterGegner++;
                    UnityEngine.Debug.Log("Spawned Enemy at" + randomx + "," + y + "," + randomz);
                    spawnRateTwo = r.Next(400,800);
                    spawnRate = 0;
                }
            

                //int SecondsToWait = r.Next(5, 15);
            } 
            

        }
    }


    public Boolean called = false;
    

    private void OnTriggerEnter(Collider collide)
    {

        //UnityEngine.Debug.Log(collide + " == " + player);
        
        if(!called) {
            UnityEngine.Debug.Log("Entered");
            source.Stop();
            source.clip = insideArena;
            source.Play();
            UnityEngine.Debug.Log("Entered");
            //if (!called) {UnityEngine.Debug.Log("Entered");spawnEnemysRandom(GegnerAnzahl);}
            called = true;
        }

    }
 
    

    private void OnTriggerExit(Collider collide)
    {
        source.Stop();
        source.clip = outside;
        source.Play();
    }

}




