using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenuScript : MonoBehaviour

    {   
    public GameObject gameOver;
    public GameObject player;
    public GameObject startMenu;

    // Start is called before the first frame update
    void Start()
    {
       this.gameObject.SetActive(false);
       startMenu.SetActive(false);
    }

    
    public void StartButton() {
        Debug.Log("START BUTTON clicked");
        this.gameObject.SetActive(false);
        player.GetComponent<HealthSystem>().Respawn();
        player.GetComponent<HealthSystem>().refresh_UI();
    }

    public void QuitEverythingButton() {
        Debug.Log("GAME WILL BE QUIT");
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }
    
}
