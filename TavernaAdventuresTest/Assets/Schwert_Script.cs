using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Schwert_Script : MonoBehaviour
{
    public bool Schadlich = false;
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
         Debug.Log("ENEMY KILLED");

        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("ENEEMY HIZZZT!!!!!!!!!!!!!");
           Enemy_Script es = collision.gameObject.GetComponent<Enemy_Script>();
            if(Schadlich == true)
            {
                es.Leben = 0;
                es.die();
            }
        }
    }
}
