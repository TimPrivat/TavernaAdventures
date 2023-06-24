using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneRotation : MonoBehaviour
{

    public bool changeDir = false;
    public Transform stone;
    public Transform stonePos;

    public Quaternion oldPos;
    public Quaternion changePos;
    public int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
        oldPos = stone.rotation;
        changePos = stonePos.rotation;

    }

    // Update is called once per frame
    void Update()
    {
        counter++;
        if(!changeDir) {

            if(counter % 4 == 0) {
                stone.Rotate(-1f,0f,0f, Space.Self);
                changeDir = stone.rotation.y < changePos.y;
            }
            //Quaternion target = Quaternion.Euler(0, 0, 0);
            //stone.rotation = Quaternion.Slerp(stone.rotation, target,  Time.deltaTime * 5);
            //stone.position += Vector3.back * 3 * Time.deltaTime;
            //changeDir = changePos.z > stone.position.z;
        } else {
            if(counter % 4 == 0) {
                stone.Rotate(1f,0f,0f, Space.Self);
                changeDir = stone.rotation.y < oldPos.y;

            }
            //stone.position += Vector3.forward * 3 * Time.deltaTime;
            //changeDir = oldPos.z > stone.position.z;
        }
        
        if(counter > 20) counter = 0;
        
    }

    
}
