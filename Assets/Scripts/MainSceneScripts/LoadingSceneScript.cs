using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingSceneScript : MonoBehaviour
{
    public string loadingScene;

    public void OnPlayeButtonClick()
    {
        print(loadingScene);
        SceneManager.LoadScene(loadingScene);
    }
}
