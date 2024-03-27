using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour
{
    public int playerNumber;

    Vector2 startPos;
    Vector2 endPos;


    //int maxCount;
    //int count;

    public float playerSpeed = 1.7f;

    bool moving = false;
    float swipeLength = 150f;

    TileManager theTile;
    public GameObject tileParents;

    CameraFollow theCamera;

    public int movingCount = 0;//이게 스코어이기도 함....
    public int movingMaxCount = 4;
    public int movingMinCount = -3;

    public GameObject sleependingImg;
    public bool pause = false;

    public bool topDetectWall = false;
    public bool bottomDetectWall = false;
    public bool leftDetectWall = false;
    public bool rightDetectWall = false;

    float maxTime = 5f;
    float time = 0f;

    public bool sleep;
    public bool crush;

    public bool saveFlag;

    Database theDB;

    private void Awake()
    {
        pause = false;
        topDetectWall = false;
        bottomDetectWall = false;
        leftDetectWall = false;
        rightDetectWall = false;
    }

    private void Start()
    {
        theTile = FindObjectOfType<TileManager>();
        theCamera = FindObjectOfType<CameraFollow>();
        sleep = false;
        crush = false;
        saveFlag = false;
    }

    private void Update()
    {
        if (!pause)
        {
            if (Input.GetMouseButtonDown(0))
            {
                startPos = Input.mousePosition;
            }

            if (Input.GetMouseButtonUp(0))
            {
                moving = true;
                endPos = Input.mousePosition;
            }

            if (moving)
            {
                if (Mathf.Abs((startPos.x - endPos.x)) > swipeLength)
                {
                    if ((startPos.x - endPos.x) > 0)//left
                    {
                        time = 0f;
                        if (!leftDetectWall)
                            this.transform.position = new Vector3(transform.position.x - playerSpeed, transform.position.y, transform.position.z);
                        this.GetComponent<Animator>().SetBool("IsLeft", true);
                        this.GetComponent<Animator>().SetBool("IsRight", false);
                        this.GetComponent<Animator>().SetBool("IsFront", false);
                        this.GetComponent<Animator>().SetBool("IsBack", false);
                    }
                    if ((startPos.x - endPos.x) < 0)//right
                    {
                        time = 0f;
                        if (!rightDetectWall)
                            this.transform.position = new Vector3(transform.position.x + playerSpeed, transform.position.y, transform.position.z);
                        this.GetComponent<Animator>().SetBool("IsLeft", false);
                        this.GetComponent<Animator>().SetBool("IsRight", true);
                        this.GetComponent<Animator>().SetBool("IsFront", false);
                        this.GetComponent<Animator>().SetBool("IsBack", false);
                    }
                }

                else if (Mathf.Abs((startPos.y - endPos.y)) > swipeLength)
                {

                    if ((startPos.y - endPos.y) > 0)//down
                    {
                        if (movingCount > movingMinCount)
                        {
                            movingCount -= 1;
                        }
                        time = 0f;
                        if (!bottomDetectWall)
                            this.transform.position = new Vector3(transform.position.x, transform.position.y - playerSpeed, transform.position.z);
                        this.GetComponent<Animator>().SetBool("IsLeft", false);
                        this.GetComponent<Animator>().SetBool("IsRight", false);
                        this.GetComponent<Animator>().SetBool("IsFront", true);
                        this.GetComponent<Animator>().SetBool("IsBack", false);
                    }
                }

                else //front
                {
                    if (movingCount < movingMaxCount)
                    {
                        movingCount += 1;
                    }
                    if (movingCount == movingMaxCount)
                    {
                        theCamera.removeFlag = true;
                    }
                    //print(Time.deltaTime);
                    time = 0f;
                    if (!topDetectWall)
                        this.transform.position = new Vector3(transform.position.x, transform.position.y + playerSpeed, transform.position.z);
                    this.GetComponent<Animator>().SetBool("IsLeft", false);
                    this.GetComponent<Animator>().SetBool("IsRight", false);
                    this.GetComponent<Animator>().SetBool("IsFront", false);
                    this.GetComponent<Animator>().SetBool("IsBack", true);
                    theTile.tilecount += 1;



                }

                if (this.transform.position.x <= -6.8f)
                    this.transform.position =
                        new Vector3(-6.7f, transform.position.y, transform.position.z);

                if (this.transform.position.x >= 6.8f)
                    this.transform.position =
                        new Vector3(6.7f, transform.position.y, transform.position.z);

                if (this.transform.position.y <= -12.9f + (theCamera.removeTileCount * playerSpeed))
                    this.transform.position =
                        new Vector3(transform.position.x, -12.9f + (theCamera.removeTileCount * playerSpeed), transform.position.z);


                moving = false;
            }
            time = time + Time.deltaTime;
            //print(time);


            if (time > maxTime)
            {
                this.GetComponent<Animator>().SetBool("IsLeft", false);
                this.GetComponent<Animator>().SetBool("IsRight", false);
                this.GetComponent<Animator>().SetBool("IsFront", false);
                this.GetComponent<Animator>().SetBool("IsBack", false);
                this.GetComponent<Animator>().SetBool("IsSleep", true);
                sleep = true;
                saveFlag = true;
                sleependingImg.SetActive(true);
                sleependingImg.GetComponent<Animator>().Play("GameOver");
                pause = true;
            }
        }
        


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            print("crash!");
            transform.position = new Vector3(transform.position.x, transform.position.y - 1.7f, transform.position.z);
            this.GetComponent<Animator>().SetBool("IsHurt", true);
            this.GetComponent<Animator>().SetBool("IsLeft", false);
            this.GetComponent<Animator>().SetBool("IsRight", false);
            this.GetComponent<Animator>().SetBool("IsFront", false);
            this.GetComponent<Animator>().SetBool("IsBack", false);
            //Time.timeScale = 0f;

            crush = true;
            saveFlag = true;
            sleependingImg.SetActive(true);
            sleependingImg.GetComponent<Animator>().Play("GameOver");
            pause = true;

        }
    }



}
