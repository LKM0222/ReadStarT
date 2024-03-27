using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISystem : MonoBehaviour
{
    public int score;
    public Text frontScore;
    public Text rearScore;
    public Text finalScore;
    public Text pauseScore;

    public Image endingImage;

    public Sprite[] endingImageArr = new Sprite[2]; //0 : sleep 1 : crush

    PlayerMoving thePlayer;
    Database theDB;

    public GameObject text;

    private void Start()
    {
        score = 0;
        thePlayer = FindObjectOfType<PlayerMoving>();
        theDB = FindObjectOfType<Database>();
        text.SetActive(true);
    }

    private void Update()
    {
        frontScore.text = score.ToString();
        rearScore.text = score.ToString();
        finalScore.text = score.ToString();
        pauseScore.text = score.ToString();
        if (thePlayer.sleep)
        {
            endingImage.sprite = endingImageArr[0];
            theDB.sleepOver[theDB.playerNum] += 1;
            theDB.overCount[theDB.playerNum] += 1;
            thePlayer.sleep = false;
        }
        if (thePlayer.crush)
        {
            endingImage.sprite = endingImageArr[1];
            theDB.accidentOver[theDB.playerNum] += 1;
            theDB.overCount[theDB.playerNum] += 1;
            thePlayer.crush = false;
            text.SetActive(false);
        }
    }
}
