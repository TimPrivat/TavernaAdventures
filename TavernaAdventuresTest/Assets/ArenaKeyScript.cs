using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArenaKeyScript : MonoBehaviour{

    public GameObject Key;
    public GameObject player;
     public GameObject TP_Pos;
    public GameObject trigger;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider collide) {

        if(collide.gameObject == player) {
              // Dashier in den Collider vom Second Key packen
            player.GetComponent<QuestVariables>().secondKey=true;
            UnityEngine.Debug.Log("Arena Complete");
            UnityEngine.Debug.Log(player.GetComponent<QuestVariables>().secondKey);
            Key.SetActive(false);
            trigger.SetActive(true);
            player.transform.position = TP_Pos.transform.position;
        }

    }
}
