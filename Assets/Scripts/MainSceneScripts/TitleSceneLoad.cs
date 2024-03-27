using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleSceneLoad : MonoBehaviour
{
    public void OnLoadingScene()
    {
        SceneManager.LoadScene("2.LoadingScene");
    }
}
