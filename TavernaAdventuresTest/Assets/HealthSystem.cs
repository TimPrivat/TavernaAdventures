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
    public GameObject PlayerSpawner;

private void Schaden(int vSchaden = 1)
        {
            if(this.Leben > 1)
            {
                this.Leben -= vSchaden;
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
                    Herzen[0].SetActive(false);
                    Herzen[1].SetActive(false);
                    Herzen[2].SetActive(false);
                    break;
                case 1:
                    Herzen[0].SetActive(true);
                    Herzen[1].SetActive(false);
                    Herzen[2].SetActive(false);
                    break;
                case 2:
                    Herzen[0].SetActive(true);
                    Herzen[1].SetActive(true);
                    Herzen[2].SetActive(false);
                    break;
                case 3:
                    Herzen[0].SetActive(true);
                    Herzen[1].SetActive(true);
                    Herzen[2].SetActive(true);
                    break;

            }
        }

        private void Respawn()
        {
            Debug.Log("RESPAWN");
            this.Leben = 3;
        this.transform.position = PlayerSpawner.transform.position;
        }
        void OnCollisionStay(Collision collision)
        {
            //Enemy other = collision.gameObject.GetComponent<>();
            //Debug.Log("Collsion with: " + collision.GetType() + collision.gameObject.name);
            if(collision.gameObject.tag == "Enemy")
            {
               // UnityEngine.Debug.Log("Enemy has been Hit");
                try
                {
                    Enemy_Script getScript = collision.gameObject.GetComponent<Enemy_Script>();
                    if(getScript.anim != null)
                    {
                        getScript.anim.SetTrigger("Hit");
                       

                    }
                    
                    //Debug.Log(getScript.targetTime);
                if (!getScript.getCooldown())
                {
                    Schaden(getScript.Schaden);
                    
                    getScript.setCooldown(true);
                }
                } catch
                {

                }
            }
        }

            // Start is called before the first frame update
    void Start()
    {
        Leben = 3;
        Herzen[0].SetActive(true);
        Herzen[1].SetActive(true);
        Herzen[2].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
