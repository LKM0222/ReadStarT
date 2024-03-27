using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSceneButtonScript : MonoBehaviour
{
    //Public Obj
    public GameObject closeObj;

    //BackButton
    public GameObject backButtonOpen;
    public GameObject backButtonClose;

    //OpenAchiveMentPopup
    public GameObject achivement;

    //OpenPlayerInfoPopup
    public GameObject playerInfo;

    //OpenOptionPopup
    public GameObject option;

    //OpenOptionDiaryPopup
    public GameObject diary;

    //OpenOptionDevelopPoup
    public GameObject developer;

    

    public void OnBackButton()
    {
        backButtonOpen.SetActive(true);
        backButtonClose.SetActive(false);
    }

    public void OpenAchivementPopup()
    {
        achivement.SetActive(true);
        closeObj.SetActive(false);
    }

    public void OpenOptionPopup()
    {
        option.SetActive(true);
        closeObj.SetActive(false);
    }

    public void OpenOptionDiaryPopup()
    {
        diary.SetActive(true);
        closeObj.SetActive(false);
    }

    public void OpenOptionDeveloperPopup()
    {
        developer.SetActive(true);
        closeObj.SetActive(false);
    }

    public void OpenPlayerInfoPopup()
    {
        playerInfo.SetActive(true);
        closeObj.SetActive(false);
    }
}


