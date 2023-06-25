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
       startMenu.SetActive(true);
       Cursor.lockState = CursorLockMode.None;
       Cursor.visible = true;
    }

    
    public void StartButton() {
        Debug.Log("START BUTTON clicked");
        this.gameObject.SetActive(false);
        player.GetComponent<HealthSystem>().refresh_UI();
        player.GetComponent<HealthSystem>().Respawn();
        
        player.transform.position = new Vector3(-1626, 122, -1437);
        startMenu.SetActive(false);

    }

    public void QuitEverythingButton() {
        Debug.Log("GAME WILL BE QUIT");
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }
    
}
