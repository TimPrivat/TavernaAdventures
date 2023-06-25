using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Invector.vCharacterController
{

    public class StartMenuScript : MonoBehaviour

    {
        public GameObject gameOver;
        public GameObject player;
        public GameObject startMenu;

         public AudioClip Traumwelt;
         public AudioClip Taverne;
         public AudioSource source;

        // Start is called before the first frame update
        void Start()
        {
            this.gameObject.SetActive(false);
            startMenu.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
           
            source.Stop();
            source.clip = Taverne;
            source.Play();

        }


        public void StartButton()
        {
            Debug.Log("START BUTTON clicked");
            this.gameObject.SetActive(false);
            player.GetComponent<HealthSystem>().refresh_UI();
            player.GetComponent<HealthSystem>().Respawn();

            player.transform.position = new Vector3(-1626, 122, -1437);
         //Debug
          //player.transform.position = new Vector3(677, 60, 511);
            startMenu.SetActive(false);
            source.Stop();
            source.clip = Traumwelt;
            source.Play();
            Cursor.lockState = CursorLockMode.Locked;

        }

        public void QuitEverythingButton()
        {
            Debug.Log("GAME WILL BE QUIT");
            Application.Quit();
        //    UnityEditor.EditorApplication.isPlaying = false;
        }

    }
}