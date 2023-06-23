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

    public GameObject enemy;
    // Start is called before the first frame update

    private System.Random r = new System.Random();

    private int x = 753;
    private int y = 50;
    private int z = 710;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private Boolean called = false;
    private void spawnEnemysRandom(int anzahl)
    {   called = true;
         UnityEngine.Debug.Log("Aufgerufen");
          
        for (int i = 0; i < anzahl; i++)
        {

            //Bestimmt das Vorzeichen der verschiebung
            int posx = r.Next(1) * 2 - 1;
            int posz = r.Next(1) * 2 - 1;

            //x +-25
            //y+- 25
            int randomx = x + (r.Next(25) * posx);
            int randomz = z + (r.Next(25) * posz);
            Instantiate(enemy, new Vector3(randomx, y, randomz), Quaternion.identity);
            UnityEngine.Debug.Log("Spawned Enemy at" + randomx + "," + y + "," + randomz);
           

            int SecondsToWait = r.Next(5, 15);
             
        }
    }

    private void OnTriggerEnter(Collider collide)
    {
        UnityEngine.Debug.Log("Entered");
        source.Stop();
        source.clip = insideArena;
        source.Play();
        if (!called) spawnEnemysRandom(GegnerAnzahl);
        

    }
 
    

    private void OnTriggerExit(Collider collide)
    {
        source.Stop();
        source.clip = outside;
        source.Play();
    }

}
