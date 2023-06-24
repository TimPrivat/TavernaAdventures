using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGate : MonoBehaviour
{

    public GameObject player;
    public Transform gate;
    public Transform gateUp;
    public bool gateOpened = false;
    public float counter = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if(gateOpened == true) {
            gate.position += Vector3.up * Time.deltaTime; 
            gateOpened = gateUp.position.y > gate.position.y;
        }
            
        
    }

    void OnTriggerEnter(Collider collide) {

        if(collide.gameObject == player && player.GetComponent<QuestVariables>().mainKey == true) {
            gateOpened = true;
            gameObject.GetComponent<BoxCollider>().enabled = false;
        }

    }
}
