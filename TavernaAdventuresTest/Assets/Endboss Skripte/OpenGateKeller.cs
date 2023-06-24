using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenGateKeller : MonoBehaviour
{

    public Transform gateClosed;
    public Transform gateOpened;

    public bool opened = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(opened) {
            gateClosed.position = gateOpened.position;
        }
    }
}
