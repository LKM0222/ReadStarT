using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public GameObject pausePopup;
    PlayerMoving thePlayer;
    

    private void Start()
    {
        thePlayer = FindObjectOfType<PlayerMoving>();
    }

    public void PauseOpenButton()
    {
        Time.timeScale = 0;
        thePlayer.pause = true;
        print("pause!");
        pausePopup.SetActive(true);
        
        thePlayer.playerSpeed = 0;
        //다른씬으로 넘어갈때 scale값을 1로 만들어줘야 될 수도 있음. 
    }

    public void PauseCloseButton()
    {
        thePlayer.pause = false;
        Time.timeScale = 1;

        pausePopup.SetActive(false);
        
        thePlayer.playerSpeed = 1.7f;
    }
}
