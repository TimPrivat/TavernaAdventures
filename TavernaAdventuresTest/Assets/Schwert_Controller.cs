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
        Debug.Log("COLSSLSLSLSLS");
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
        }
        
    }
}
