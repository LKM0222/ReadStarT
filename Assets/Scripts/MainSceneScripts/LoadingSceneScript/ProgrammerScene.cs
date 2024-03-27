using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProgrammerScene : MonoBehaviour
{
    Database theDB;

    private void Start()
    {
        theDB = FindObjectOfType<Database>();
    }

    public void ProgrammerStart()
    {
        theDB.playerNum = 0;
        theDB.playCount[0] += 1;
        SceneManager.LoadScene("Programmer");
    }
}
