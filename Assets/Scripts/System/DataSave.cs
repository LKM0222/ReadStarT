using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataSave : MonoBehaviour
{
    string fullPath = "Assets/Resources/Test"; //Assets/Resources/Test.txt
    //string fullPath = Application.persistentDataPath + "/gamedata/Test";
    Database theDB;
    UISystem theUI;
    PlayerMoving thePlayer;

    // Start is called before the first frame update
    void Start()
    {
        theDB = FindObjectOfType<Database>();
        thePlayer = FindObjectOfType<PlayerMoving>();
        theUI = FindObjectOfType<UISystem>();
        print(File.Exists(fullPath));
    }

    // Update is called once per frame
    void Update()
    {
        //데이터 처리 후 txt에 세이브

        if(theUI.score > theDB.highScore[theDB.playerNum])
        {
            theDB.highScore[theDB.playerNum] = theUI.score;
        }


        //txt에 세이브하는 코드
        if (thePlayer.saveFlag)
        {
            TextAsset txt = Resources.Load<TextAsset>("Test");

            if (File.Exists(fullPath))
            {
                StreamWriter ow = new StreamWriter(fullPath + ".txt");

                //prog
                ow.WriteLine(PlayerPrefs.GetInt("Prog_HighScore") + ";" +
                    PlayerPrefs.GetInt("Prog_OverCount") + ";" +
                    PlayerPrefs.GetInt("Prog_PlayCount") + ";" +
                    PlayerPrefs.GetInt("Prog_SleepOver") + ";" +
                    PlayerPrefs.GetInt("Prog_AccidentOver"));

                //Prod
                ow.WriteLine(PlayerPrefs.GetInt("Prog_HighScore") + ";" +
                    PlayerPrefs.GetInt("Prog_OverCount") + ";" +
                    PlayerPrefs.GetInt("Prog_PlayCount") + ";" +
                    PlayerPrefs.GetInt("Prog_SleepOver") + ";" +
                    PlayerPrefs.GetInt("Prog_AccidentOver"));

                //Desi
                ow.WriteLine(PlayerPrefs.GetInt("Prog_HighScore") + ";" +
                    PlayerPrefs.GetInt("Prog_OverCount") + ";" +
                    PlayerPrefs.GetInt("Prog_PlayCount") + ";" +
                    PlayerPrefs.GetInt("Prog_SleepOver") + ";" +
                    PlayerPrefs.GetInt("Prog_AccidentOver"));

                //Baby
                ow.WriteLine(PlayerPrefs.GetInt("Prog_HighScore") + ";" +
                    PlayerPrefs.GetInt("Prog_OverCount") + ";" +
                    PlayerPrefs.GetInt("Prog_PlayCount") + ";" +
                    PlayerPrefs.GetInt("Prog_SleepOver") + ";" +
                    PlayerPrefs.GetInt("Prog_AccidentOver"));



                ow.Flush();
                ow.Close();

            }
            else
            {
                print("Writeing Error!!");
            }
        }

        //if (thePlayer.saveFlag)
        //{
        //    TextAsset txt = Resources.Load<TextAsset>("Test");

        //    if (File.Exists(fullPath))
        //    {
        //        StreamWriter ow = new StreamWriter(fullPath+".txt");

        //        //prog
        //        ow.WriteLine(theDB.highScore[0] + ";" +
        //            theDB.overCount[0] + ";" +
        //            theDB.playCount[0] + ";" +
        //            theDB.sleepOver[0] + ";" +
        //            theDB.accidentOver[0]);

        //        //Prod
        //        ow.WriteLine(theDB.highScore[1] + ";" +
        //            theDB.overCount[1] + ";" +
        //            theDB.playCount[1] + ";" +
        //            theDB.sleepOver[1] + ";" +
        //            theDB.accidentOver[1]);

        //        //Desi
        //        ow.WriteLine(theDB.highScore[2] + ";" +
        //            theDB.overCount[2] + ";" +
        //            theDB.playCount[2] + ";" +
        //            theDB.sleepOver[2] + ";" +
        //            theDB.accidentOver[2]);

        //        //Baby
        //        ow.WriteLine(theDB.highScore[3] + ";" +
        //            theDB.overCount[3] + ";" +
        //            theDB.playCount[3] + ";" +
        //            theDB.sleepOver[3] + ";" +
        //            theDB.accidentOver[3]);



        //        ow.Flush();
        //        ow.Close();

        //    }
        //    else
        //    {
        //        print("Writeing Error!!");
        //    }
        //}
    }
}
