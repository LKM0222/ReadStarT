using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//making Tile...!
public class TileManager : MonoBehaviour
{
    //TileArray
    public GameObject[] tileArr = new GameObject[10];
    public Transform initGameobj;//생성을 위한 위치를 저장하는 오브젝트

    //Tile Y Position
    public float tileYPos = -8.5f;


    public int r; //random integer
    public int saveR = -1;//중복생성 방지 


    public GameObject tileParent;

    public int tilecount = 1;

    //obstacle moving
    public float objSpeed;

    //맵이 로딩됐을때 10개 생성 후
    //플레이어가 이동할때마다 맨 앞의 타일 하나를 생성
    private void Start()
    {
        for (float count = 0; count < 15; )
        {
            r = Random.Range(0,tileArr.Length); //미리 저장해둔 맵에서 랜덤으로 하나를 불러온다.
            if (r != saveR) //생성했던 타일이 아니라면
            {
                initGameobj.position =
                    new Vector3(initGameobj.position.x, tileYPos, initGameobj.position.z);//생성 위치를 가져온다.

                GameObject tiles = Instantiate(tileArr[r], initGameobj.position, initGameobj.rotation);//맵을 생성한다.
                tiles.transform.parent = tileParent.transform; //맵을 생성하고 타일 그룹안으로 넣는다.
                tileYPos += 1.7f; //다음 생성을 위해 생성오브젝트를 한칸 올린다.

                saveR = r; //이전 랜덤값을 저장한다.
                count++;
            }
            else
            {
                continue;
            }
        }
    }

    private void Update()
    {
        if (tilecount % 10 == 0)
        {
            for (float count = 0; count < 12;)
            {
                r = Random.Range(0, tileArr.Length);

                if (r != saveR)
                {
                    //print("r is " + r);

                    initGameobj.position =
                        new Vector3(initGameobj.position.x, tileYPos, initGameobj.position.z);

                    GameObject tiles = Instantiate(tileArr[r], initGameobj.position, initGameobj.rotation);
                    tiles.transform.parent = tileParent.transform;
                    tileYPos += 1.7f;
                    //print("Tile Y Pos is " + tileYPos);
                    saveR = r;
                    count++;
                }
                else
                {
                    continue;
                }
            }
            tilecount = 1;
        }

    }
}
