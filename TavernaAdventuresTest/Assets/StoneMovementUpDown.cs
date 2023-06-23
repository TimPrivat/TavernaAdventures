using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneMovementUpDown : MonoBehaviour
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
            stone.position += Vector3.up * 5 * Time.deltaTime;
            changeDir = changePos.y < stone.position.y;
        } else {
            stone.position += Vector3.down * 5 * Time.deltaTime;
            changeDir = oldPos.y < stone.position.y;
        }
        
        
    }

    
}
