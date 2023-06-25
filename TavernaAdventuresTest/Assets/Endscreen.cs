using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endscreen : MonoBehaviour
{
    public GameObject endscreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider collide) {
        endscreen.SetActive(true);
    }
}
