using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharactorButton : MonoBehaviour
{
    public GameObject onCloseObj;
    public GameObject onOpenObj;
    public int charactorNumber;
    //ButtonDatabase theBtnDB;

    private void Start()
    {
        //theBtnDB = FindObjectOfType<ButtonDatabase>();
    }

    public void CharactorButtonClick()
    {
        //theBtnDB.sceneLoadingNum = charactorNumber;
        onCloseObj.SetActive(false);
        onOpenObj.SetActive(true);
    }
}
