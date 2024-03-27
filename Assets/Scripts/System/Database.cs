using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class Database : MonoBehaviour
{
    //Player Data ???? txt??? ???. ?? \n ?? ;?? ??.
    //0=prog 1=prod 2=desi 3=baby
    public int playerNum;


    public int[] highScore = new int[4];
    public int[] overCount = new int[4];
    public int[] playCount = new int[4];
    public int[] sleepOver = new int[4];
    public int[] accidentOver = new int[4];

    UISystem theUI;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        theUI = FindObjectOfType<UISystem>();

        //if (!Directory.Exists(Application.persistentDataPath + "/gamedata"))
        //{
        //    Directory.CreateDirectory(Application.persistentDataPath + "/gamedata");
        //}

        //TextAsset testText = Resources.Load<TextAsset>(Application.persistentDataPath + "Test");
        TextAsset testText = Resources.Load<TextAsset>("Test");

        //List<Dictionary<string, object>> testdata = CSVReader.Read("testdata");

        string dataStr = testText.text;
        string[] dataRow;
        string[] tempArr;
        string[,] dataCol = new string[4, 5];

       
        
        if (testText)
        {
            //print(dataStr);
            dataRow = dataStr.Split('\n');
            

            for(int i = 0; i < dataRow.Length - 1; i++)
            {
                tempArr = dataRow[i].Split(';');
                //print("temp arr " + i);
                for(int j = 0; j < tempArr.Length; j++)
                {
                    dataCol[i, j] = tempArr[j];
                }
                ////데이터 넘겨주는 방법을 playerpefs로 넘겨준다
                //highScore[i] = int.Parse(dataCol[i, 0]);
                //overCount[i] = int.Parse(dataCol[i, 1]);
                //playCount[i] = int.Parse(dataCol[i, 2]);
                //sleepOver[i] = int.Parse(dataCol[i, 3]);
                //accidentOver[i] = int.Parse(dataCol[i, 4]);

                //PlayerPrefs.SetInt(GetCharString(i) + "_HighScore", highScore[i]);
                //PlayerPrefs.SetInt(GetCharString(i) + "_OverCount", overCount[i]);
                //PlayerPrefs.SetInt(GetCharString(i) + "_PlayCount", playCount[i]);
                //PlayerPrefs.SetInt(GetCharString(i) + "_SleepOver", sleepOver[i]);
                //PlayerPrefs.SetInt(GetCharString(i) + "_AccidentOver", accidentOver[i]);
                //PlayerPrefs.Save();

                PlayerPrefs.SetInt(GetCharString(i) + "_HighScore", int.Parse(dataCol[i, 0]));
                PlayerPrefs.SetInt(GetCharString(i) + "_OverCount", int.Parse(dataCol[i, 0]));
                PlayerPrefs.SetInt(GetCharString(i) + "_PlayCount", int.Parse(dataCol[i, 0]));
                PlayerPrefs.SetInt(GetCharString(i) + "_SleepOver", int.Parse(dataCol[i, 0]));
                PlayerPrefs.SetInt(GetCharString(i) + "_AccidentOver", int.Parse(dataCol[i, 0]));
                PlayerPrefs.Save();

                if (PlayerPrefs.HasKey(GetCharString(i) + "_HighScore"))
                {
                    highScore[i] = PlayerPrefs.GetInt(GetCharString(i) + "_HighScore");
                }
                else
                {
                    print("PlayerPrefs.GetInt " + i + "_HighScore Err!");
                }

                if (PlayerPrefs.HasKey(GetCharString(i) + "_OverCount"))
                {
                    overCount[i] = PlayerPrefs.GetInt(GetCharString(i) + "_OverCount");
                }
                else
                {
                    print("PlayerPrefs.GetInt " + i + "_OverCount Err!");
                }

                if (PlayerPrefs.HasKey(GetCharString(i) + "_PlayCount"))
                {
                    playCount[i] = PlayerPrefs.GetInt(GetCharString(i) + "_PlayCount");
                }
                else
                {
                    print("PlayerPrefs.GetInt " + i + "_PlayCount Err!");
                }

                if (PlayerPrefs.HasKey(GetCharString(i) + "_SleepOver"))
                {
                    sleepOver[i] = PlayerPrefs.GetInt(GetCharString(i) + "_SleepOver");
                }
                else
                {
                    print("PlayerPrefs.GetInt " + i + "_SleepOver Err!");
                }

                if (PlayerPrefs.HasKey(GetCharString(i) + "_AccidentOver"))
                {
                    accidentOver[i] = PlayerPrefs.GetInt(GetCharString(i) + "_AccidentOver");
                }
                else
                {
                    print("PlayerPrefs.GetInt " + i + "_AccidentOver Err!");
                }                

            }

            SceneManager.LoadScene("3.MainScene");
        }
        else
        {
            print("loading Error!!");
        }
        
    }

    
    string GetCharString(int i)
    {
        switch (i)
        {
            case 0:
                return "Prog";

            case 1:
                return "Prod";

            case 2:
                return "Desi";

            case 3:
                return "Baby";

            default:
                return "Error";
        }
    }

}

