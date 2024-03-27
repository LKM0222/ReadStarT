using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottonDetectingWall : MonoBehaviour
{
    PlayerMoving thePlayer;

    private void Start()
    {
        thePlayer = FindObjectOfType<PlayerMoving>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Wall")
        {
            print("Detecting topWall");
            thePlayer.bottomDetectWall = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Wall")
        {
            print("Detecting topWall");
            thePlayer.bottomDetectWall = false;
        }
    }
}
