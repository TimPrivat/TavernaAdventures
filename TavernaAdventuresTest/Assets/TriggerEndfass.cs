using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEndfass : MonoBehaviour
{
    public GameObject fass;
    public GameObject fassEnde;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerEnter(Collider collide) {

        fass.SetActive(false);
        fassEnde.SetActive(true);
        

    }
}
