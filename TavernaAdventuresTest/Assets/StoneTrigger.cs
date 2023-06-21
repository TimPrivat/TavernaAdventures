using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneTrigger : MonoBehaviour
{

    public Transform stone;
    public bool falls = false;
    public bool faling = false;
    public bool jumpBackUp = false;
    public int counter = 0;
    public float oldYPosition;
    Vector3 yposition;
    Vector3 oldyposition;
    Vector3 oldypositionTwo;

    // Start is called before the first frame update
    void Start()
    {
        yposition = new Vector3(stone.position.x, -11, stone.position.z);
        oldypositionTwo = new Vector3(stone.position.x, stone.position.y, stone.position.z);
        oldYPosition = stone.position.y;
    }

    // Update is called once per frame
    void Update()
    {

            
        if(falls || jumpBackUp) {
            counter++;
        }

        if(counter == 600) {
            if(!jumpBackUp){
                falls = false;
                counter = 0;
                faling = true;
            } else {
                jumpBackUp = false;
                stone.position = Vector3.zero;
                stone.position += oldypositionTwo;
                counter = 0;
            }
        }

        if(faling == true) {
            stone.position += Vector3.down * 8 * Time.deltaTime;
        }

        if(stone.position.y < yposition.y) {
            faling = false;
            jumpBackUp = true;
        } 
    }


    private void OnTriggerEnter(Collider collide) {

        if(!faling) {
            falls = true;
        }
    }
}
