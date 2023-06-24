using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Schwert_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Enemy_Script.times_died++;
            Debug.Log("ENEMY KILLED");
            Destroy(collision.gameObject);
        }
        
    }
}
