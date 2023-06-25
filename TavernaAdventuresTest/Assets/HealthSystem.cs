using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Invector.vCharacterController
{
public class HealthSystem : MonoBehaviour
{

    public GameObject gameOver;
    public GameObject[] Herzen;
        public int Leben = 3;
public GameObject[] _Herzen;
        public int _Leben;
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
                {
                    Herzen[0].SetActive(false);
                    gameOver.SetActive(true);
                    Spieler.GetComponent<vThirdPersonInput>().Active_Movement = false;
                    Cursor.lockState = CursorLockMode.None;
                    Cursor.visible = true;
                    //this.Respawn();
                    } 
                else
                { Debug.LogError("FEHLER: " + this.Leben); }
            }
            refresh_UI();
        }

        public void refresh_UI()
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

        public void Respawn()
        {   
            Debug.Log("RESPAWN");
            this.Leben = 3;
            this.transform.position = PlayerSpawner.transform.position;
            Spieler.GetComponent<vThirdPersonInput>().Active_Movement = true;
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
}
