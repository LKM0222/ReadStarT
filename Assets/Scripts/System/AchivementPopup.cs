using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;

public class AchivementPopup : MonoBehaviour
{

    //업적은 한번 달성때만 플레이되어야함.
    //업적은 게임 시작때마다 계속 플레이되면 안됨.
    //업적 데이터베이스와 연결되어야함.
    public Text achivementText;
    public string[] progAchiveArr;
    public string[] prodAchiveArr;
    public string[] desiAchiveArr;
    public string[] babyAchiveArr;


    private void Update()
    {
        if (this.transform.position.y >= 1120f)//이거 수정해야함....
            this.gameObject.SetActive(false);

        
    }


}
