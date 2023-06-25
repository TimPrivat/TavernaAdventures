using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Invector.vCharacterController
{
    public class Collectable_Script : MonoBehaviour
    {
        public string NAME_ITEM = "Empty";

         public GameObject TP_Pos;
        string[] it;
        public GameObject PLAYER;
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
            if (collision.gameObject.name == "Burghardt")
            {
                it = collision.gameObject.GetComponent<vThirdPersonController>().Collected_Itemes;
                it[collision.gameObject.GetComponent<vThirdPersonController>().itemscount] = NAME_ITEM;
                collision.gameObject.GetComponent<vThirdPersonController>().Collected_Itemes = it;
             
                   PLAYER.transform.position = TP_Pos.transform.position;
             
                Destroy(this);


            }
        }
    }
}