using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour
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

    
    public void RestartButton() {
        Debug.Log("RESTART BUTTON clicked");
        this.gameObject.SetActive(false);
        player.GetComponent<HealthSystem>().Respawn();
        player.GetComponent<HealthSystem>().refresh_UI();
        player.transform.position = new Vector3(187, 74, 48);
    }

    public void QuitGameButton() {
        Debug.Log("QUIT GAME BUTTON clicked");
        Time.timeScale = 0;
        gameOver.SetActive(false);
        startMenu.SetActive(true);
    }
    
}
