using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoadeScripts : MonoBehaviour
{

    public void OnMainSceneClikc()
    {
        SceneManager.LoadScene("3.MainScene");
    }
}
