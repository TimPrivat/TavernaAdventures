using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endtrigger2 : MonoBehaviour
{
    public GameObject fassTrigger;
    public GameObject DialogueBox;
    public GameObject spieler;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collide) {
        fassTrigger.SetActive(true);
        DialogueBox.SetActive(true);
        spieler.GetComponent<QuestVariables>().done = true;
    }
}
