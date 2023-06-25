using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunterfallTrigger : MonoBehaviour
{

    public GameObject respawnPoint;
    public Vector3 respawnPoint2;

    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        respawnPoint2 = respawnPoint.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collide) {
        player.transform.position = respawnPoint2;
    }
}
