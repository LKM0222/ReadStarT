using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchivementDatabase : MonoBehaviour
{
    Database theDB;
    UISystem theUI;
    public GameObject theAchivementPopup;
 

    //programmer
    int prog_achive1 = 30; //30점 도달
    int prog_achive2 = 1; //움직임 없는 게임오버 1회
    int prog_achive3 = 2; //2회플레이
    int prog_achive4 = 2; //2회 게임오버
    int prog_achive5 = 50; //50점 도달
    int prog_achive6 = 1; //사고로 게임오버 1회
    int prog_achive7 = 3; //3회 플레이
    bool[] prog_achiveBool = new bool[7];

    //producer
    int prod_achive1 = 2;//미움직임 게임오버 2회
    int prod_achive2 = 1;//첫 게임 오버
    int prod_achive3 = 5;//5회 플레이
    int prod_achive4 = 30; //30점 도달
    int prod_achive5 = 3; //뒤로 이동 3회
    bool[] prod_achiveBool = new bool[5];

    //designer
    int desi_achive1 = 1; //미움직임 게임오버 2회
    int desi_achive2 = 1; //첫 게임 오버
    int desi_achive3 = 0; //최고점수보다 낮게 나올시 (이건 함수로 구현...)
    int desi_achive4 = 0; //최고점수에서 +- 10 이내일시
    bool[] desi_achiveBool = new bool[4];

    //baby
    int baby_achive1 = 30; //30점 도달
    int baby_achive2 = 50; //50점 도달
    int baby_achive3 = 1; //게임플레이 1회
    bool[] baby_achiveBool = new bool[3];

    private void Start()
    {
        theDB = FindObjectOfType<Database>();
        theUI = FindObjectOfType<UISystem>();
    }

    private void Update()
    {
        switch (theDB.playerNum)
        {
            case 0:
                //print("achive checking");
                if(theUI.score >= prog_achive1 && !prog_achiveBool[0])
                {
                    
                    theAchivementPopup.SetActive(true);
                    prog_achiveBool[0] = true;
                }

                if(theDB.sleepOver[theDB.playerNum] == prog_achive2 && !prog_achiveBool[1])
                {
                    theAchivementPopup.SetActive(true);
                    prog_achiveBool[1] = true;
                }
                if(theDB.playCount[theDB.playerNum] == prog_achive3 && !prog_achiveBool[2])
                {
                    theAchivementPopup.SetActive(true);
                    prog_achiveBool[2] = true;
                }
                if (theDB.overCount[theDB.playerNum] == prog_achive4 && !prog_achiveBool[3])
                {
                    theAchivementPopup.SetActive(true);
                    prog_achiveBool[3] = true;
                }
                if (theUI.score >= prog_achive5 && !prog_achiveBool[4])
                {
                    theAchivementPopup.SetActive(true);
                    prog_achiveBool[4] = true;
                }
                if (theDB.accidentOver[theDB.playerNum] == prog_achive6 && !prog_achiveBool[5])
                {
                    theAchivementPopup.SetActive(true);
                    prog_achiveBool[5] = true;
                }
                if (theDB.playCount[theDB.playerNum] == prog_achive7 && !prog_achiveBool[6])
                {
                    theAchivementPopup.SetActive(true);
                    prog_achiveBool[6] = true;
                }
                break;

            case 1:


                break;

            case 2:
                break;

            case 3:
                break;
        }
    }

}


