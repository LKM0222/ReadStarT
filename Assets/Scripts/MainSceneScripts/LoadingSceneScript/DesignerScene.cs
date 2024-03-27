using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DesignerScene : MonoBehaviour
{
    Database theDB;

    private void Start()
    {
        theDB = FindObjectOfType<Database>();
    }

    public void DesignerStart()
    {
        theDB.playerNum = 2;
        theDB.playCount[2] += 1;
        SceneManager.LoadScene("Designer");
    }
}
