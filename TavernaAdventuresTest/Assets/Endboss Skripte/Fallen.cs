using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fallen : MonoBehaviour
{
    public GameObject[] falle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collide) {
        
        foreach(GameObject c in falle) {
            Destroy(c);
        }
    }
}
