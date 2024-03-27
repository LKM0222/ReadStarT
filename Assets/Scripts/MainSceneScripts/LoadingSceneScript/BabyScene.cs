using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BabyScene : MonoBehaviour
{
    Database theDB;

    private void Start()
    {
        theDB = FindObjectOfType<Database>();
    }

    public void BabyStart()
    {
        theDB.playerNum = 3;
        theDB.playCount[3] += 1;
        SceneManager.LoadScene("Baby");
    }
}
