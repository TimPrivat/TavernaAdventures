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
       startMenu.SetActive(false);
    }

    
    public void RestartButton() {
        Debug.Log("RESTART BUTTON clicked");
        this.gameObject.SetActive(false);
        player.GetComponent<HealthSystem>().Respawn();
        player.GetComponent<HealthSystem>().refresh_UI();
    }

    public void QuitGameButton() {
        Debug.Log("QUIT GAME BUTTON clicked");
        gameOver.SetActive(false);
        startMenu.SetActive(true);
    }
    
}
