using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject target;

    public float cameraSpeed;

    public float smoothSpeed = 3;
    public Vector2 offset;
    public float limitMinX, limitMaxX, limitMinY, limitMaxY;
    float cameraHalfWidth, cameraHalfHeight;

    PlayerMoving thePlayer;

    public int removeTileCount = 0;

    public bool removeFlag = false;

    UISystem theUI;

    private void Start()
    {
        cameraHalfWidth = Camera.main.aspect * Camera.main.orthographicSize;
        cameraHalfHeight = Camera.main.orthographicSize;
        //print(cameraHalfHeight + " " + cameraHalfWidth);

        thePlayer = FindObjectOfType<PlayerMoving>();
        theUI = FindObjectOfType<UISystem>();
    }
    private void Update()
    {
        if (removeFlag)
        {
            if (thePlayer.movingCount == thePlayer.movingMaxCount)
            {
                if (!thePlayer.topDetectWall)
                {
                    limitMinY += 1.7f;
                    removeTileCount += 1;
                    theUI.score += 1;
                    removeFlag = false;
                }
            }
        }
    }

    private void LateUpdate()
    {
        Vector3 desiredPosition = new Vector3(
            Mathf.Clamp(target.transform.position.x + offset.x, limitMinX + cameraHalfWidth, limitMaxX - cameraHalfWidth),   // X
            Mathf.Clamp(target.transform.position.y + offset.y, limitMinY + cameraHalfHeight - cameraSpeed, limitMaxY - cameraHalfHeight) + cameraSpeed, // Y
            -10);                                                                                                  // Z
        transform.position = Vector3.Lerp(transform.position, desiredPosition , Time.deltaTime * smoothSpeed);
    }

}
