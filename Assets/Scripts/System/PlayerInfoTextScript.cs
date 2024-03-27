using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfoTextScript : MonoBehaviour
{
    Database theDB;
    public Text prog;
    public Text prod;
    public Text desi;
    public Text baby;

    private void Start()
    {
        theDB = FindObjectOfType<Database>();
    }

    // Update is called once per frame
    void Update()
    {
        prog.text = "개발자 \n" +
            "최 고 점 수  : " + theDB.highScore[0] + "\n" +
            "플레이한 횟수 : " + theDB.playCount[0] + "\n" +
            "게임오버 횟수 : " + theDB.overCount[0] + "\n" +
            "잠 잔 횟 수  : " + theDB.playCount[0] + "\n" +
            "사 고 횟 수  : " + theDB.playCount[0];

        prod.text = "기획자 \n" +
            "최 고 점 수  : " + theDB.highScore[1] + "\n" +
            "플레이한 횟수 : " + theDB.playCount[1] + "\n" +
            "게임오버 횟수 : " + theDB.overCount[1] + "\n" +
            "잠 잔 횟 수  : " + theDB.playCount[1] + "\n" +
            "사 고 횟 수  : " + theDB.playCount[1];

        desi.text = "디자이너 \n" +
            "최 고 점 수  : " + theDB.highScore[2] + "\n" +
            "플레이한 횟수 : " + theDB.playCount[2] + "\n" +
            "게임오버 횟수 : " + theDB.overCount[2] + "\n" +
            "잠 잔 횟 수  : " + theDB.playCount[2] + "\n" +
            "사 고 횟 수  : " + theDB.playCount[2];

        baby.text = "아이 \n" +
            "최 고 점 수  : " + theDB.highScore[3] + "\n" +
            "플레이한 횟수 : " + theDB.playCount[3] + "\n" +
            "게임오버 횟수 : " + theDB.overCount[3] + "\n" +
            "잠 잔 횟 수  : " + theDB.playCount[3] + "\n" +
            "사 고 횟 수  : " + theDB.playCount[3];
    }
}
