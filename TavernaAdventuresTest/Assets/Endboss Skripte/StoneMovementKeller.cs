using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneMovementKeller : MonoBehaviour
{

    public bool changeDir = false;
    public Transform stone;
    public Transform stonePos;

    public Vector3 oldPos;
    public Vector3 changePos;

    // Start is called before the first frame update
    void Start()
    {
        oldPos = stone.position;
        changePos = stonePos.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(!changeDir) {
            stone.position += Vector3.forward * 3 * Time.deltaTime;
            changeDir = changePos.z < stone.position.z;
        } else {
            stone.position += Vector3.back * 3 * Time.deltaTime;
            changeDir = oldPos.z < stone.position.z;
        }
        
        
    }

    
}
