using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Invector.vCharacterController
{
    public class Collectable_Script : MonoBehaviour
    {
        public string NAME_ITEM = "Empty";
        public Vector3 new_Location;
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
                if(new_Location != new Vector3())
                {
                    PLAYER.transform.position = new_Location;
                }
                Destroy(this);


            }
        }
    }
}