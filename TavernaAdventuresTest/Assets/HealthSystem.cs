using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{


    public GameObject[] Herzen;
        public int Leben = 3;
private GameObject[] _Herzen;
        private int _Leben;
        public GameObject Spieler;

private void Schaden()
        {
            if(this.Leben > 1)
            {
                this.Leben -= 1;
                Debug.Log("Leben neu: " + this.Leben);
            } else
            {
                if(this.Leben == 1)
                { this.Respawn();} 
                else
                { Debug.LogError("FEHLER: " + this.Leben); }
            }
            refresh_UI();
        }

        void refresh_UI()
        {
            switch (Leben)
            {
                case 0:
                    Herzen[0].active = false;
                    Herzen[1].active = false;
                    Herzen[2].active = false;
                    break;
                case 1:
                    Herzen[0].active = true;
                    Herzen[1].active = false;
                    Herzen[2].active = false;
                    break;
                case 2:
                    Herzen[0].active = true;
                    Herzen[1].active = true;
                    Herzen[2].active = false;
                    break;
                case 3:
                    Herzen[0].active = true;
                    Herzen[1].active = true;
                    Herzen[2].active = true;
                    break;

            }
        }

        private void Respawn()
        {
            Debug.Log("RESPAWN");
            this.Leben = 3;
            this.transform.position = new Vector3(0, 0, 0);
        }

        void OnCollisionEnter(Collision collision)
        {
            //Enemy other = collision.gameObject.GetComponent<>();
            Debug.Log("Collsion with: " + collision.GetType() + collision.gameObject.name);
            if(collision.gameObject.tag == "Enemy")
            {
                this.Schaden();
            }
        }

            // Start is called before the first frame update
    void Start()
    {
        Leben = 3;
        Herzen[0].active = true;
        Herzen[1].active = true;
        Herzen[2].active = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
