using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProducerScene : MonoBehaviour
{
    Database theDB;

    private void Start()
    {
        theDB = FindObjectOfType<Database>();
    }

    public void ProducerStart()
    {
        theDB.playerNum = 1;
        theDB.playCount[1] += 1;
        SceneManager.LoadScene("Producer");
    }
}
